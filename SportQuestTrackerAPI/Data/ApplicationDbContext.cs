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
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        //    modelBuilder.Entity<Gadget>()
        //            .HasData(
        //                new Gadget
        //                {
        //                    GadgetId = 1,
        //                    Price = 20,
        //                    CompanyId = 3,
        //                    Image = "url(Reebook.png)",
        //                    Name = "Nike shoes",
        //                    Quantity = "100",
        //                    TypeOfProduct = 1,
        //                },
        //                new Gadget
        //                {
        //                    GadgetId = 2,
        //                    Price = 30,
        //                    CompanyId = 1,
        //                    Image = "url(Addidas.png)",
        //                    Name = "Addidas shoes",
        //                    Quantity = "100",
        //                    TypeOfProduct = 1,
        //                },
        //                new Gadget
        //                {
        //                    GadgetId = 3,
        //                    Price = 50,
        //                    CompanyId = 2,
        //                    Image = "url(Reebook.png)",
        //                    Name = "Reebook Shoes",
        //                    Quantity = "100",
        //                    TypeOfProduct = 1,
        //                });
        //    modelBuilder.Entity<Transaction>()
        //        .HasData(
        //            new Transaction
        //            {
        //                TransactionId = 1,
        //                UserId = 1,
        //                GadgetId = 1,
        //                Date = new DateTime(2020, 09, 12, 11, 50, 33)
        //            },
        //            new Transaction
        //            {
        //                TransactionId = 2,
        //                UserId = 2,
        //                GadgetId = 1,
        //                Date = new DateTime(2020, 11, 14, 07, 52, 21)
        //            },
        //            new Transaction
        //            {
        //                TransactionId = 3,
        //                UserId = 3,
        //                GadgetId = 1,
        //                Date = new DateTime(2020, 04, 27, 21, 33, 13)
        //            });

        //    modelBuilder.Entity<Company>()
        //        .HasData(
        //            new Company
        //            {
        //                Id = 1,
        //                Email = "nike@gmail.com",
        //                Password = "nike@2020",
        //                Name = "Nike",
        //                Points = 1023,

        //            },
        //            new Company
        //            {
        //                Id = 1,
        //                Email = "adidas@gmail.com",
        //                Password = "adidas@2020",
        //                Name = "Adidas",
        //                Points = 1023,
        //            },
        //            new Company
        //            {
        //                Id = 1,
        //                Email = "reebook@gmail.com",
        //                Password = "reebook@2020",
        //                Name = "Reebok",
        //                Points = 1023,
        //            });


        //    modelBuilder.Entity<Company>()
        //        .HasMany(e => e.Gadgets)
        //        .WithOne(c => c.Company);


        //}
    }
}
