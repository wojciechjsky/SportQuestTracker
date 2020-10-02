using System;
using Microsoft.EntityFrameworkCore;
using SportQuestTracker.Models;
using SportQuestTracker.Models.ClassModels;
using SportQuestTracker_UI.Data.Models.ClassModels;

namespace SportQuestTracker_UI.DataBase
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Gadget> Gadgets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Company> Companies { get; set; }

    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                    .HasData(new User
                        {
                            UserId = 1,
                            Email = "pati@wp.pl",
                            Password = "Large",
                            FirstName = "Patrycja",
                            Surname = "Kowalska",
                            Points = 30,
                            Coins = 30,
                            Admin = true,

                        },
                        new User
                        {
                            UserId = 2,
                            Email = "wojti@wp.pl",
                            Password = "Medium",
                            FirstName = "Wojciech",
                            Surname = "Nowak",
                            Points = 20,
                            Coins = 20,
                            Admin = false,

                        },
                        new User
                        {
                            UserId = 3,
                            Email = "baksiu@wp.pl",
                            Password = "Small",
                            FirstName = "Baksiu",
                            Surname = "Baksiowski",
                            Points = 110,
                            Coins = 110,
                            Admin = false,
                        });

            modelBuilder.Entity<Gadget>()
                    .HasData(
                        new Gadget
                        {
                            GadgetId = 1,
                            Price = 20,
                            CompanyId = 3,
                            Image = "url(Reebook.png)",
                            Name = "Nike shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        },
                        new Gadget
                        {
                            GadgetId = 2,
                            Price = 30,
                            CompanyId = 1,
                            Image = "url(Addidas.png)",
                            Name = "Addidas shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        },
                        new Gadget
                        {
                            GadgetId = 3,
                            Price = 50,
                            CompanyId = 2,
                            Image = "url(Reebook.png)",
                            Name = "Reebook Shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        });
            modelBuilder.Entity<Transaction>()
                .HasData(
                    new Transaction
                    {
                        TransactionId = 1,
                        UserId = 1,
                        GadgetId = 1,
                        Date = new DateTime(2020, 09, 12, 11, 50, 33)
                    },
                    new Transaction
                    {
                        TransactionId = 2,
                        UserId = 2,
                        GadgetId = 1,
                        Date = new DateTime(2020, 11, 14, 07, 52, 21)
                    },
                    new Transaction
                    {
                        TransactionId = 3,
                        UserId = 3,
                        GadgetId = 1,
                        Date = new DateTime(2020, 04, 27, 21, 33, 13)
                    });

            modelBuilder.Entity<Company>()
                .HasData(
                    new Company
                    {
                        CompanyId = 1,
                        CompanyName = "Nike",
                        CollectedCoins = 1000,
                        Logo = "url(Nike.png)"
                    },
                    new Company
                    {
                        CompanyId = 2,
                        CompanyName = "Adidas",
                        CollectedCoins = 2000,
                        Logo = "url(Adidas.png)"
                    },
                    new Company
                    {
                        CompanyId = 3,
                        CompanyName = "Reebook",
                        CollectedCoins = 550,
                        Logo = "url(Reebook.png)"
                    });


            modelBuilder.Entity<Company>()
                .HasMany(e => e.Gadgets)
                .WithOne(c => c.Company);


        }

    }
}
