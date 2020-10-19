using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SportQuestTrackerAPI.Data.Models
{
    //public class AppUserDbContext : IdentityDbContext<AppUser>
    //{
    //    public DbSet<Gadget> Gadgets { get; set; }
    //    public DbSet<TransactionModel> Transactions { get; set; }
    //    public DbSet<Company> Companies { get; set; }
    //    public DbSet<Quest> Quests { get; set; }
    //    public AppUserDbContext(DbContextOptions options):base(options)
    //    {
            
    //    }
    //}
    public class AppUser: IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        public int Points { get; set; } = 0;
        public int Coins { get; set; } = 0;
    }
}
