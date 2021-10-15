using Mathance.Areas.Identity.Data;
using Mathance.Data;
using Mathance.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathance.Controllers
{
    public class PostsController : Controller
    {
        private readonly MathanceContext _context;

        private readonly UserManager<MathanceUser> _userManager;
        public PostsController(MathanceContext context, UserManager<MathanceUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Post(int? id)
        {
            if (id == null)
                return NotFound();
            Post post = _context.Posts                          
                        .Include(a=>a.Author)
                        .Include(i=>i.Images)
                        .Include(t=>t.Tags)
                        .Include(c=>c.Comments)
                            .ThenInclude(a=>a.Author)
                        .Include(c=>c.Comments)
                            .ThenInclude(a=>a.Likes)
                        .Include(l=>l.Comments)
                           .ThenInclude(d=>d.Dislikes)
                        .Include(ra=>ra.RightAnswers)
                            .ThenInclude(p=>p.Post)
                        .Where(p=>p.Id == id)
                        .FirstOrDefault();

            if (post == null)
                return NotFound();

            var userId = _userManager.GetUserId(User);
            MathanceUser currentUser = _context.Users
                                       .Include(a => a.RightAnswers)
                                       .Where(i => i.Id == userId)
                                       .FirstOrDefault();
            ViewBag.isSolved = false;
            if (currentUser != null)
            {
                ViewBag.isSolved = GetIfSolved(post, currentUser);
                ViewBag.CurrentUser = currentUser;
            }
            return View(post);
        }   

        [Authorize]
        private bool GetIfSolved(Post post, MathanceUser user)
        {
            if (post.Author == user)
                return true;

            var rightAnswers = post.RightAnswers.Select(a => a.Data).ToList();
            var userAnswers = user.RightAnswers.Select(a => a.Data).ToList();

            var result = userAnswers.Intersect(rightAnswers).ToList();

            var isSolved = result.Count != 0 ? true : false;

            return isSolved;
        }

        [Authorize]
        public async void CommentPost(int? id, string text)
        {
            var post = _context.Posts
                .Include(c => c.Comments)
                .FirstOrDefault(p=>p.Id == id);
            var author = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            var comment = new Comment
            {
                PostedTime = DateTime.UtcNow.AddHours(3),
                Text = text,
                Post = post,
                Author = author
            };
            post.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }
        
        public async Task<IActionResult> SubmitAnswer(int? id, string answer)
        {
            string userId = _userManager.GetUserId(User);
            MathanceUser currentUser = _context.Users
                                       .Include(a => a.RightAnswers)
                                       .Where(i => i.Id == userId)
                                       .FirstOrDefault();
            Post post = _context.Posts
                        .Include(ra => ra.RightAnswers)
                            .ThenInclude(p => p.Post)
                        .Where(p => p.Id == id)
                        .FirstOrDefault();
            List<string> answers = _context.RightAnswers
                                    .Where(r=>r.Post == post)
                                    .Select(a => a.Data).ToList();
            if (answers.Contains(answer))
            {
                Answer newAnswer = new Answer
                {
                    Post = post,
                    Data = answer
                };

                currentUser.RightAnswers.Add(newAnswer);

                await _context.SaveChangesAsync();

                return Redirect($"/Posts/Post/{id}");
            }

            return Redirect($"/Posts/Post/{id}");

        }

        [HttpGet, ActionName("GetTagsList")]

        public IActionResult GetTagsList()
        {
            var tagsList = _context.Tags.Select(t => t.Name).Distinct().AsNoTracking().ToList();
            var list = JsonConvert.SerializeObject(tagsList,
                Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
            return Content(list, "application/json");
        }
    }
}
