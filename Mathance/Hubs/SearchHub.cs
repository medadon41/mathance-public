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

            if(results.Length == 0)
            {
                List<Comment> comments = _context.Comments
                    .Include(p=>p.Post)
                    .Where(f => EF.Functions.FreeText(f.Text, searchText)).ToList();
                if(comments.Count != 0)
                {
                    results = comments.Select(p => p.Post).ToArray();
                }
            }

            await Clients.All.SendAsync("SearchResult", results);
        }

    }
}