using Mathance.Areas.Identity.Data;
using Mathance.Data;
using Mathance.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathance.Hubs
{
    public class CommentHub : Hub
    {
        private readonly MathanceContext _context;
        private readonly UserManager<MathanceUser> _userManager;

        public CommentHub(MathanceContext context, UserManager<MathanceUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task SendComment(string postid, string user, string message)
        {
            int id = int.Parse(postid);
            var post = _context.Posts
                .Include(c => c.Comments)
                .FirstOrDefault(p => p.Id == id);
            var author = _context.Users
                        .FirstOrDefault(u => u.UserName == user);
            var comment = new Comment
            {
                PostedTime = DateTime.UtcNow.AddHours(3),
                Text = message,
                Post = post,
                Author = author
            };
            post.Comments.Add(comment);
            await _context.SaveChangesAsync();

            string postedOn = $" on {comment.PostedTime.ToString("HH:mm MM.dd.yy")}";
            await Clients.All.SendAsync("ReceiveComment", user, message, postedOn, comment.Id);
        }
        private Comment GetCurrentComment(int? id, int commId)
        {
            var post = _context.Posts
                .Include(c => c.Comments)
                    .ThenInclude(l => l.Likes)
                        .ThenInclude(a => a.User)
                .Include(c => c.Comments)
                    .ThenInclude(d => d.Dislikes)
                        .ThenInclude(a => a.User)
                .FirstOrDefault(p => p.Id == id);

            return post.Comments.FirstOrDefault(i => i.Id == commId);
        }
        public async Task LikeComment(string post, string comm, string user)
        {
            bool hasLiked = true;
            var currentUser = _context.Users
                        .FirstOrDefault(u => u.UserName == user);

            var postid = int.Parse(post);
            var commId = int.Parse(comm);

            var currentComment = GetCurrentComment(postid, commId);

            var usersLiked = currentComment.Likes.Select(a => a.User).ToList();
            var usersDisliked = currentComment.Dislikes.Select(a => a.User).ToList();

            //if user already liked current comment, removes their like
            if (usersLiked.Contains(currentUser))
            {
                Like userLike = currentComment.Likes.Where(a => a.User.Equals(currentUser)).First();
                currentComment.Likes.Remove(userLike);
                await _context.SaveChangesAsync();
                hasLiked = false;
                await Clients.All.SendAsync("ReceiveLike", comm, currentComment.Likes.Count, currentComment.Dislikes.Count, hasLiked);
                return;
            }
            currentComment.Likes.Add(new Like { Comment = currentComment, User = currentUser });

            //if user already have a dislike on the current comment, removes dislike
            if (usersDisliked.Contains(currentUser))
            {
                Dislike userDislike = currentComment.Dislikes.Where(a => a.User.Equals(currentUser)).First();
                currentComment.Dislikes.Remove(userDislike);
            }
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveLike", comm, currentComment.Likes.Count, currentComment.Dislikes.Count, hasLiked);
        }

        public async Task DislikeComment(string post, string comm, string user)
        {
            bool hasDisliked = true;
            var currentUser = _context.Users
                        .FirstOrDefault(u => u.UserName == user);

            var postid = int.Parse(post);
            var commId = int.Parse(comm);

            var currentComment = GetCurrentComment(postid, commId);

            var usersLiked = currentComment.Likes.Select(a => a.User).ToList();
            var usersDisliked = currentComment.Dislikes.Select(a => a.User).ToList();

            //if user already disliked current comment, removes their dislike
            if (usersDisliked.Contains(currentUser))
            {
                Dislike userLike = currentComment.Dislikes.Where(a => a.User.Equals(currentUser)).First();
                currentComment.Dislikes.Remove(userLike);
                await _context.SaveChangesAsync();
                hasDisliked = false;
                await Clients.All.SendAsync("ReceiveDislike", comm, currentComment.Likes.Count, currentComment.Dislikes.Count, hasDisliked);
                return;
            }
            currentComment.Dislikes.Add(new Dislike { Comment = currentComment, User = currentUser });

            //if user already have a like on the current comment, removes like
            if (usersLiked.Contains(currentUser))
            {
                Like userLike = currentComment.Likes.Where(a => a.User.Equals(currentUser)).First();
                currentComment.Likes.Remove(userLike);
            }
            await _context.SaveChangesAsync();

            await Clients.All.SendAsync("ReceiveDislike", comm, currentComment.Likes.Count, currentComment.Dislikes.Count, hasDisliked);
        }

        public async Task TrySearch(string searchText)
        {
            Post[] results = _context.Posts
                .Where(f => EF.Functions.FreeText(f.Text, searchText)).ToArray();

            if (results.Length == 0)
            {
                List<Comment> comments = _context.Comments
                    .Include(p => p.Post)
                    .Where(f => EF.Functions.FreeText(f.Text, searchText)).ToList();
                if (comments.Count != 0)
                {
                    results = comments.Select(p => p.Post).ToArray();
                }
            }

            await Clients.All.SendAsync("SearchResult", results);
        }

        public async Task Rate(string rate, string postid)
        {
            int rating = int.Parse(rate);
            var postId = int.Parse(postid);

            Post post = _context.Posts
                        .FirstOrDefault(p => p.Id == postId);

            if(post.Rating == 0)
            {
                post.Rating += rating;
                await _context.SaveChangesAsync();
                await Clients.All.SendAsync("SearchResult", post.Rating);
                return;
            }

            post.Rating = (post.Rating + rating) / 2;
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("UpdateRating", post.Rating);
        }
    }
}
