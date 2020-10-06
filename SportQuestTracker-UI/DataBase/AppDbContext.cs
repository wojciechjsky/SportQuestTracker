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
                            PhoneNumber = "123456678"

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
                            PhoneNumber = "123456678"

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
                            PhoneNumber = "123456678"
                        });

            modelBuilder.Entity<Gadget>()
                    .HasData(
                        new Gadget
                        {
                            GadgetId = 1,
                            Price = 20,
                            CompanyId = 3,
                            Image = "https://cdn.pixabay.com/photo/2020/07/15/18/30/sneakers-5408667__340.png",
                            Name = "Nike shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        },
                        new Gadget
                        {
                            GadgetId = 2,
                            Price = 30,
                            CompanyId = 1,
                            Image = "https://media.istockphoto.com/photos/adidas-superstar-picture-id458068097?b=1&k=6&m=458068097&s=170667a&w=0&h=7LAV8cgmrSUtSpqszncqx1Yq5RbVeCR5JzbakOCpkb4=",
                            Name = "Addidas shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        },
                        new Gadget
                        {
                            GadgetId = 3,
                            Price = 50,
                            CompanyId = 2,
                            Image = "https://cdn.pixabay.com/photo/2018/03/09/10/41/reebok-3211174__340.png",
                            Name = "Reebook Shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        },

                        new Gadget
                        {
                            GadgetId = 4,
                            Price = 50,
                            CompanyId = 2,
                            Image = "https://cdn.pixabay.com/photo/2018/03/09/10/41/reebok-3211174__340.png",
                            Name = "Reebook Shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        },
                        new Gadget
                            {
                                GadgetId = 5,
                                Price = 50,
                                CompanyId = 2,
                                Image = "https://cdn.pixabay.com/photo/2018/03/09/10/41/reebok-3211174__340.png",
                                Name = "Reebook Shoes",
                                Quantity = "100",
                                TypeOfProduct = 1,
                            }

                        );
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
                        Id = 1,
                        Name = "Nike",
                        Password = "111111",
                        Email = "1111@wp.pl",
                        Points = 1000,

                    },
                    new Company
                    {
                        Id = 2,
                        Name = "Adidas",
                        Password = "111111",
                        Email = "1111@wp.pl",
                        Points = 1000,

                    },
                    new Company
                    {
                        Id = 3,
                        Name = "Reebook",
                        Password = "111111",
                        Email = "1111@wp.pl",
                        Points = 1000,

                    });


            //modelBuilder.Entity<Company>()
            //    .HasMany(e => e.Gadgets)
            //    .WithOne(c => c.Company);


        }

    }
}
