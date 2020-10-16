using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

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
                    UserName = "admin",
                    Email = "admin@gmail.com"
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
                    UserName = "Patrycja",
                    Email = "pati@gmail.com"
                };
                var result = await userManager.CreateAsync(user, "Komputer%20");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Client");
                }
            }
            if (await userManager.FindByEmailAsync("wojtek@gmail.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Wojtek",
                    Email = "wojtek@gmail.com"
                };
                var result = await userManager.CreateAsync(user, "Komputer%20");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "User");
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
            if (!await roleManager.RoleExistsAsync("Client"))
            {
                var role = new IdentityRole
                {
                    Name = "Client"
                };
                await roleManager.CreateAsync(role);
            }
        }
    }
}
