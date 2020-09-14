using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SportQuestTracker.Data
{
    /// <summary>
    /// THIS IS FOR STUDYING PURPOSES DO NOT TOUCH
    /// </summary>
    public class SeedData
    {
        public static async Task Seed(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager);
            await SeedUsers(userManager);
        }
        private static async Task SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (await userManager.FindByEmailAsync("admin@spt.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@spt.com"
                };
                var result = await userManager.CreateAsync(user, "qwerty123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
            }
            if (await userManager.FindByEmailAsync("user1@spt.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "user1",
                    Email = "user1@spt.com"
                };
                var result = await userManager.CreateAsync(user, "qwerty123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
            }
            if (await userManager.FindByEmailAsync("user2@spt.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "user2",
                    Email = "user2@spt.com"
                };
                var result = await userManager.CreateAsync(user, "qwerty123");
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
