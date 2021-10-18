using Mathance.Data;
using Mathance.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathance.Hubs
{
    public class SearchHub : Hub
    {
        private readonly MathanceContext _context;

        public SearchHub(MathanceContext context)
        {
            _context = context;
        }
        public async Task TrySearch(string searchText)
        {
            Post[] results = _context.Posts
                .Where(f => EF.Functions.FreeText(f.Text, searchText)).ToArray();
            
            List<Comment> comments = _context.Comments
                .Include(p=>p.Post)
                .Where(f => EF.Functions.FreeText(f.Text, searchText)).ToList();
               
            var _results = comments.Select(p => p.Post).ToArray();


            foreach (var item in _results)
                results.Append(item);

            await Clients.All.SendAsync("SearchResult", results.Distinct().ToArray());
        }

    }
}