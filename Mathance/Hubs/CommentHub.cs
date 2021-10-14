using Mathance.Areas.Identity.Data;
using Mathance.Data;
using Mathance.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
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
            await Clients.All.SendAsync("ReceiveComment", user, message, postedOn);
        }
    }
}
