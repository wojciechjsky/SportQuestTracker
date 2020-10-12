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
    public class DetailsModel : PageModel
    {
        private readonly SportQuestTracker.Data.ApplicationDbContext _context;

        public DetailsModel(SportQuestTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users
                .Include(u => u.Company).FirstOrDefaultAsync(m => m.UserId == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
