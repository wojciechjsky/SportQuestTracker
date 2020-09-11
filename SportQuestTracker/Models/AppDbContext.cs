using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportQuestTracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        private DbSet<User> Users { get; set; }
        private DbSet<Gadget> Gadgets { get; set; }
        private DbSet<Transaction> Transactions { get; set; }
        private DbSet<Company> Companies { get; set; }

    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    }
}
