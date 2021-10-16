using Mathance.Data;
using Mathance.Models;
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

        public IActionResult Index()
        {
            List<Post> results = _context.Posts
                 .Where(f => EF.Functions.FreeText(f.Text, "ras")).AsNoTracking().ToList();

            if (results.Count == 0)
            {
                List<Comment> comments = _context.Comments
                    .Include(p => p.Post)
                    .Where(f => EF.Functions.FreeText(f.Text, "ras")).AsNoTracking().ToList();
                if (comments.Count != 0)
                {
                    ViewBag.Msg = "??";
                    results = comments.Select(p => p.Post).ToList();
                    foreach (var item in results)
                    {
                        item.Comments = null;
                    }
                }
            }
            return View(results);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
