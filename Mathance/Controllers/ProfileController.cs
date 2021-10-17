using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Mathance.Areas.Identity.Data;
using Mathance.Data;
using Mathance.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mathance.Controllers
{
    public class ProfileController : Controller
    {
        private readonly MathanceContext _context;
        private readonly UserManager<MathanceUser> _userManager;
        private readonly Cloudinary _cloudinary;

        public ProfileController(MathanceContext context, UserManager<MathanceUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            Account account = new Account(
           Environment.GetEnvironmentVariable("cloudapi"),
           Environment.GetEnvironmentVariable("cloudapikey"),
           Environment.GetEnvironmentVariable("cloudapisecret"));

            Cloudinary cloudinary = new Cloudinary(account);
            _cloudinary = cloudinary;
        }

        public IActionResult Index(string name)
        {
            MathanceUser currentUser = _context.Users
                                       .Include(a => a.RightAnswers)
                                       .Include(p => p.Posts)
                                         .ThenInclude(i => i.Images)
                                       .Include(p => p.Posts)
                                         .ThenInclude(t => t.Tags)
                                       .Include(p => p.Posts)
                                         .ThenInclude(c => c.Comments)
                                            .ThenInclude(a => a.Author)
                                       .Include(p => p.Posts)
                                         .ThenInclude(r => r.RightAnswers)
                                       .Where(i => i.UserName == name)
                                       .FirstOrDefault();
            ViewBag.name = currentUser.UserName;
            return View(currentUser);
        }

        public IActionResult Create(string name)
        {
            ViewBag.Name = name;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(Post post, List<IFormFile> images, List<string> tags, List<string> rightanswers, string name)
        {
            post.Text = post.Text.Replace(Environment.NewLine, @"\r\n");
            _context.Posts.Add(post);

            post.Author = _context.Users.FirstOrDefault(i => i.UserName == name);
            post.PostedDate = DateTime.UtcNow.AddHours(3);
            post.Tags.AddRange(GetTags(post, tags));
            post.Images.AddRange(GetImages(post, images));
            post.RightAnswers.AddRange(GetAnswers(post, rightanswers));

            await _context.SaveChangesAsync();
            return Redirect($"/Posts/Post/{post.Id}");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Post post = _context.Posts
                        .Include(a => a.Author)
                        .Include(i => i.Images)
                        .Include(t => t.Tags)
                        .Include(ra => ra.RightAnswers)
                        .Where(p => p.Id == id)
                        .FirstOrDefault();

            ViewBag.Name = post.Author.UserName;
            post.Text = post.Text.Replace(@"\r\n", Environment.NewLine);
            return View(post);
        }

        public IActionResult Delete(int id)
        {
            Post post = _context.Posts
                        .Include(a=>a.Author)
                        .Include(c=>c.Comments)
                        .FirstOrDefault(p => p.Id == id);
            string uname = post.Author.UserName;
            _context.Posts.Remove(post);
            _context.SaveChanges();

            return Redirect($"~/Profile?name={uname}");
        }

        [HttpPost]
        public async Task<IActionResult> EditPost(Post newPost, List<IFormFile> images, List<string> tags, List<string> rightanswers, string name)
        {
            Post post = _context.Posts
                        .Include(u=>u.Author)
                        .Include(t=>t.Tags)
                        .Include(i=>i.Images)
                        .Include(a=>a.RightAnswers)
                        .Where(p => p.Author.UserName == name)
                        .FirstOrDefault();
            post.Topic = newPost.Topic;
            post.Title = newPost.Title;
            post.Text = newPost.Text;
            post.Author = _context.Users.FirstOrDefault(i => i.UserName == name); 

            var tagslist = GetTags(post, tags);
            if (!post.Tags.SequenceEqual(tagslist) && tags.First() != null)
            {
                post.Tags.RemoveRange(0, post.Tags.Count);
                post.Tags.AddRange(tagslist);
            }
            if(images.Count != 0)
            {
                post.Images.RemoveRange(0, post.Images.Count);
                post.Images.AddRange(GetImages(post, images));
            }

            var answerslist = GetAnswers(post, rightanswers);
            if (!post.RightAnswers.SequenceEqual(answerslist) && rightanswers.First() != null)
            {
                post.RightAnswers.RemoveRange(0, post.RightAnswers.Count);
                post.RightAnswers.AddRange(GetAnswers(post, rightanswers));
            }

            post.Text = post.Text.Replace(Environment.NewLine, @"\r\n");
            await _context.SaveChangesAsync();
            return Redirect($"/Posts/Post/{post.Id}");
        }

        [HttpPost]
        public List<Tag> GetTags(Post post, List<string> tags)
        {
            var tagslist = tags.Select(t =>
               new Tag { Name = t, Post = post}).ToList();
            return tagslist;
        }

        [HttpPost]
        public List<Answer> GetAnswers(Post post, List<string> answers)
        {
            var answerlist = answers.Select(a =>
                new Answer { Post = post, Data = a}).ToList();
            return answerlist;
        }

        [HttpPost]
        public List<Image> GetImages(Post post, List<IFormFile> images)
        {
            List<Image> imagelist = new();
            foreach (var formFile in images)
            {
                if (formFile.Length > 0)
                {
                    string link = null;
                    using (var stream = new MemoryStream())
                    { 
                        formFile.CopyTo(stream);
                        stream.Position = 0;
                        var uploadParams = new ImageUploadParams()
                        {
                            File = new FileDescription(formFile.FileName, stream),
                        };
                        var uploadResult = _cloudinary.Upload(uploadParams);
                        link = $"{uploadResult.Url}";
                    }
                    var img = new Image
                    {
                        Link = link,
                        Post = post
                    };
                   imagelist.Add(img);
                }
            }
            return imagelist;
        }
    }

}
