using Mathance.Data;
using Mathance.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mathance.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MathanceContext _context;

        public HomeController(ILogger<HomeController> logger, MathanceContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(string sort)
        {
            var posts = GetPostsList();
            ViewBag.AllTags = _context.Tags.Select(t => t.Name).Distinct().ToList();
            if (sort != "Rating" && sort != "Newest" && sort != null)
            {
                return View(SortByTag(posts, sort));
            }
            posts.Reverse();
            if (sort == "Rating") posts = posts
                                          .OrderByDescending(r => r.Rating).ToList();

            return View(posts);
        }

        private List<Post> SortByTag(List<Post> posts, string sort)
        {
            List<Post> sorted = new();
             foreach (var item in posts)
                foreach (var tag in item.Tags)
                    if (tag.Name == sort)
                        sorted.Add(item);
            return sorted;
        }

        public List<Post> GetPostsList()
        {
            List<Post> posts = _context.Posts
                .Include(c => c.Author)
                .Include(k => k.Comments)
                .Include(t => t.Tags).ToList();
            return posts;
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return LocalRedirect(returnUrl);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
