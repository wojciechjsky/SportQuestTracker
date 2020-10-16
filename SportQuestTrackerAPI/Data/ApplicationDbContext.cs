using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportQuestTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Gadget> Gadgets { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }


    }
}
