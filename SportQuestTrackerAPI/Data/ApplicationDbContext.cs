using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportQuestTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Gadget> Gadgets { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Quest> Quests { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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
                        Price = 22,
                        CompanyId = 1,
                        Image = "https://cdn.pixabay.com/photo/2020/07/15/18/30/sneakers-5408667__340.png",
                        Name = "Nike shoes",
                        Quantity = "50",
                        TypeOfProduct = 1,
                    },
                    new Gadget
                    {
                        GadgetId = 2,
                        Price = 34,
                        CompanyId = 2,
                        Image =
                            "https://media.istockphoto.com/photos/adidas-superstar-picture-id458068097?b=1&k=6&m=458068097&s=170667a&w=0&h=7LAV8cgmrSUtSpqszncqx1Yq5RbVeCR5JzbakOCpkb4=",
                        Name = "Addidas shoes",
                        Quantity = "50",
                        TypeOfProduct = 1,
                    },
                    new Gadget
                    {
                        GadgetId = 3,
                        Price = 44,
                        CompanyId = 3,
                        Image = "https://th.bing.com/th/id/OIP.oI3Ua_ewEKpTj4BFaVh-XQHaHa?pid=Api&rs=1",
                        Name = "Reebook Shoes",
                        Quantity = "50",
                        TypeOfProduct = 1,
                    },

                    new Gadget
                    {
                        GadgetId = 4,
                        Price = 55,
                        CompanyId = 3,
                        Image = "https://th.bing.com/th/id/OIP.c9wNrBxOCc8xJ6nMjNkaOAHaHa?pid=Api&rs=1",
                        Name = "Reebook Shoes",
                        Quantity = "30",
                        TypeOfProduct = 2,
                    },
                    new Gadget
                    {
                        GadgetId = 5,
                        Price = 22,
                        CompanyId = 3,
                        Image = "https://www.tights.no/wp-content/uploads/sites/7/2019/11/0003886_womens-best-paradise-leggings-paradise-green.jpeg",
                        Name = "Reebook leggins",
                        Quantity = "100",
                        TypeOfProduct = 2,
                    },
                    
                    new Gadget
                    {
                        GadgetId = 5,
                        Price = 22,
                        CompanyId = 3,
                        Image = "https://www.prodirectrunning.com/ProductImages/Gallery_2/173400.jpg",
                        Name = "Reebook leggins",
                        Quantity = "100",
                        TypeOfProduct = 2,
                    },
                    new Gadget
                    {
                        GadgetId = 6,
                        Price = 43,
                        CompanyId = 5,
                        Image = "https://th.bing.com/th/id/OIP.kn2UEE6mcOM2Vug_53APgwHaHa?pid=Api&rs=1",
                        Name = "4F Jacket",
                        Quantity = "100",
                        TypeOfProduct = 3,
                    },
                    new Gadget
                    {
                        GadgetId = 7,
                        Price = 15,
                        CompanyId = 3,
                        Image = "https://i.pinimg.com/originals/86/c7/e9/86c7e947912318d5b788bebcd8715ba9.jpg",
                        Name = "Reebook Jacket",
                        Quantity = "100",
                        TypeOfProduct = 3,
                    },
                    new Gadget
                    {
                        GadgetId = 8,
                        Price = 25,
                        CompanyId = 4,
                        Image = "https://www.zoltansport.pl/pol_pl_Bluza-meska-Puma-Essentials-TR-czarna-851771-01-30168_1.jpg",
                        Name = "Puma Jacket",
                        Quantity = "100",
                        TypeOfProduct = 3,
                    },
                    new Gadget
                    {
                        GadgetId = 9,
                        Price = 30,
                        CompanyId = 3,
                        Image = "https://th.bing.com/th/id/OIP.nm2uowz7lsKkEXiPkdItAwHaHa?pid=Api&rs=1",
                        Name = "Nike Jacket",
                        Quantity = "100",
                        TypeOfProduct = 3,
                    }
                );
            //modelBuilder.Entity<Transaction>()
            //    .HasData(
            //        new Transaction
            //        {
            //            TransactionId = 1,
            //            UserId = 1,
            //            GadgetId = 1,
            //            Date = new DateTime(2020, 09, 12, 11, 50, 33)
            //        },
            //        new Transaction
            //        {
            //            TransactionId = 2,
            //            UserId = 2,
            //            GadgetId = 1,
            //            Date = new DateTime(2020, 11, 14, 07, 52, 21)
            //        },
            //        new Transaction
            //        {
            //            TransactionId = 3,
            //            UserId = 3,
            //            GadgetId = 1,
            //            Date = new DateTime(2020, 04, 27, 21, 33, 13)
            //        });

            modelBuilder.Entity<Company>()
                .HasData(
                    new Company
                    {
                        Id = 1,
                        Name = "Nike",
                        Password = "111111",
                        Email = "marketing@nike.com.pl",
                        Points = 1000,

                    },
                    new Company
                    {
                        Id = 2,
                        Name = "Adidas",
                        Password = "111111",
                        Email = "promo@adidas.com",
                        Points = 1000,

                    },
                    new Company
                    {
                        Id = 3,
                        Name = "Reebook",
                        Password = "111111",
                        Email = "media@reebook.com",
                        Points = 1000,

                    },
                    new Company
                    {
                        Id = 4,
                        Name = "Puma",
                        Password = "111111",
                        Email = "contactus@puma.com",
                        Points = 1000,

                    },
                    new Company
                    {
                        Id = 5,
                        Name = "4F",
                        Password = "111111",
                        Email = "customerservice@4f.com",
                        Points = 1000,

                    });

            modelBuilder.Entity<Quest>() 
                .HasData(
                    new Quest
                    {
                        Id = 1,
                        Name = "Walk 5km",
                        CoinReward = 4,
                        IsDone = false,
                    },
                    new Quest
                    {
                        Id = 2,
                        Name = "Running 2km",
                        CoinReward = 2,
                        IsDone = false,
                    },
                    new Quest
                    {
                        Id = 3,
                        Name = "Walk 10km",
                        CoinReward = 8,
                        IsDone = false,
                    },
                    new Quest
                    {
                        Id = 4,
                        Name = "Swimming 1 km",
                        CoinReward = 6,
                        IsDone = false,
                    },
                    new Quest
                    {
                        Id = 5,
                        Name = "Running 3km",
                        CoinReward = 3,
                        IsDone = false,
                    },
                    new Quest
                    {
                        Id = 6,
                        Name = "Weightlifting 30 minutes",
                        CoinReward = 5,
                        IsDone = false,
                    },
                    new Quest
                    {
                        Id = 7,
                        Name = "Running 5km",
                        CoinReward = 6,
                        IsDone = false,
                    },
                    new Quest
                    {
                        Id = 8,
                        Name = "Cardio 30 minutes",
                        CoinReward = 2,
                        IsDone = false,
                    },
                    new Quest
                    {
                        Id = 9,
                        Name = "Cardio 60 minutes",
                        CoinReward = 4,
                        IsDone = false,
                    },
                    new Quest
                    {
                        Id = 10,
                        Name = "Cycling 10 km",
                        CoinReward = 3,
                        IsDone = false
                    },
                    new Quest
                    {
                        Id = 11,
                        Name = "Cycling 20 km",
                        CoinReward = 5,
                        IsDone = false
                    },
                    new Quest
                    {
                        Id = 12,
                        Name = "Cycling 30 km",
                        CoinReward = 7,
                        IsDone = false
                    }

                );

        }
    }


}

