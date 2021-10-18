using Mathance.Areas.Identity.Data;
using Mathance.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Mathance.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly MathanceContext _context;

        private readonly UserManager<MathanceUser> _userManager;

        private readonly SignInManager<MathanceUser> _signInManager;
        public AdminController(MathanceContext context, UserManager<MathanceUser> userManager, SignInManager<MathanceUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Authorize(Roles = "admin")]
        public IActionResult UsersTable()
        {
            var userlist = _context.Users.ToList();

            @ViewData["Title"] = "Admin Panel";
            return View(userlist);
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = _context.Users
                       .Include(p => p.Posts)
                       .Include(a => a.RightAnswers)
                       .Where(u => u.Id == id)
                       .FirstOrDefault();
            var usercomments = _context.Comments
                                .Include(a => a.Author)
                                .Include(l => l.Likes)
                                .Include(d => d.Dislikes)
                                .Where(u => u.Author.Id == user.Id)
                                .ToList();
            var userlikes = _context.Likes
                            .Include(u => u.User)
                            .Where(i => i.User.Id == user.Id)
                            .ToList();
            var userdislikes = _context.Dislikes
                           .Include(u => u.User)
                           .Where(i => i.User.Id == user.Id)
                           .ToList();

            _context.Likes.RemoveRange(userlikes);
            _context.Dislikes.RemoveRange(userdislikes);
            _context.Comments.RemoveRange(usercomments);
            _context.Users.Remove(user);

            await _context.SaveChangesAsync();
            return Redirect("/Admin/UsersTable");
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ToggleBlock(string id)
        {
            var user = _context.Users
                       .Where(u => u.Id == id)
                       .FirstOrDefault();
            user.IsBlocked = user.IsBlocked ? false : true;
            await _context.SaveChangesAsync();
            return Redirect("/Admin/UsersTable");
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ToggleAdmin(string id)
        {
            var user = _context.Users
                       .Where(u => u.Id == id)
                       .FirstOrDefault();

            var userRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
            if(userRole == "user") {
                await _userManager.RemoveFromRoleAsync(user, "user");
                await _userManager.AddToRoleAsync(user, "admin");
            } 
            else if(userRole == "admin") {
                await _userManager.RemoveFromRoleAsync(user, "admin");
                await _userManager.AddToRoleAsync(user, "user");
            } else
            {
                await _userManager.AddToRoleAsync(user, "user");
            }
            await _userManager.UpdateAsync(user);
            return Redirect("/Admin/UsersTable");
        }
    }
}
