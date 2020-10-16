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
        public DbSet<Quest> Quests { get; set; }

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
                            },

                         new Gadget
                         {
                             GadgetId = 6,
                             Price = 120,
                             CompanyId = 1,
                             Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%3Fid%3DOIP.2io6iXzhP0WZByWmz3Ld8QHaHa%26pid%3DApi&f=1",
                             Name = "Nike Shoes",
                             Quantity = "100",
                             TypeOfProduct = 1,
                         },
                        new Gadget
                        {
                            GadgetId = 6,
                            Price = 120,
                            CompanyId = 1,
                            Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmarionex.pl%2Fpol_pl_Biustonosz-Reebok-Cardio-Strappy-Bra-stanik-sportowy-termoaktywny-fitness-12864_2.jpg&f=1&nofb=1",
                            Name = "Nike Shoes",
                            Quantity = "100",
                            TypeOfProduct = 3,
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
                        CompanyGadgets = {new Gadget
                        {
                            GadgetId = 5,
                            Price = 50,
                            CompanyId = 2,
                            Image = "https://cdn.pixabay.com/photo/2018/03/09/10/41/reebok-3211174__340.png",
                            Name = "Reebook Shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        }},
                        Id = 1,
                        Name = "Nike",
                        Password = "111111",
                        Email = "marketing@nike.com.pl",
                        Points = 1000,

                    },
                    new Company
                    {
                        CompanyGadgets = {new Gadget
                        {
                            GadgetId = 5,
                            Price = 50,
                            CompanyId = 2,
                            Image = "https://cdn.pixabay.com/photo/2018/03/09/10/41/reebok-3211174__340.png",
                            Name = "Reebook Shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        }},
                        Id = 2,
                        Name = "Adidas",
                        Password = "111111",
                        Email = "marketing@adidas.com",
                        Points = 1000,

                    },
                    new Company
                    {
                        CompanyGadgets = {new Gadget
                        {
                            GadgetId = 5,
                            Price = 50,
                            CompanyId = 2,
                            Image = "https://cdn.pixabay.com/photo/2018/03/09/10/41/reebok-3211174__340.png",
                            Name = "Reebook Shoes",
                            Quantity = "100",
                            TypeOfProduct = 1,
                        }},
                        Id = 3,
                        Name = "Reebook",
                        Password = "111111",
                        Email = "marketing@reebook.com",
                        Points = 1000,
                        

                    });

            modelBuilder.Entity<Quest>()
                .HasData(
                new Quest
                {
                    Id=1,
                    Name="Walk 5km",
                    CoinReward = 4,
                    IsDone = false,
                },
                new Quest
                {
                    Id = 2,
                    Name = "Jogging 2km",
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
                    Name = "Jogging 3km",
                    CoinReward = 3,
                    IsDone = false,
                }

                );


        }

    }
}
