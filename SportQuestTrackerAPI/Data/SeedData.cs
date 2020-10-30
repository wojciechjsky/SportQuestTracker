using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SportQuestTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.Data
{
    public static class SeedData
    {
        public static async Task Seed(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager);
            await SeedUsers(userManager);
        }
        private static async Task SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (await userManager.FindByEmailAsync("admin@gmail.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    //FirstName = "Wojtek",
                    //Surname = "Jablonski",
                    //Points = 1000,
                    //Coins = 1000
                };
                var result = await userManager.CreateAsync(user, "Komputer%20");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
            }
            if (await userManager.FindByEmailAsync("pati@gmail.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "pati@gmail.com",
                    Email = "pati@gmail.com",
                    //FirstName = "Patrycja",
                    //Surname = "Peczyńska",
                    //Points = 1000,
                    //Coins = 1000
                };
                var result = await userManager.CreateAsync(user, "Komputer%20");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
            }
            if (await userManager.FindByEmailAsync("baksiu@gmail.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "baksiu@gmail.com",
                    Email = "baksiu@gmail.com",
                    //FirstName = "Baksiu",
                    //Surname = "Baksiowski",
                    //Points = 1000,
                    //Coins = 1000
                };
                var result = await userManager.CreateAsync(user, "Komputer%20");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
            }
        }
        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Administrator"))
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
                await roleManager.CreateAsync(role);
            }
            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                var role = new IdentityRole
                {
                    Name = "Customer"
                };
                await roleManager.CreateAsync(role);
            }
        }
    }
}
