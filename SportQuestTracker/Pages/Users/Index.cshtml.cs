using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportQuestTracker.Data;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly SportQuestTracker.Data.ApplicationDbContext _context;

        public IndexModel(SportQuestTracker.Data.ApplicationDbContext context, IList<User> user)
        {
            _context = context;
            User = user;
        }

        public new IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users
                .Include(u => u.Company).ToListAsync();
        }
    }
}
