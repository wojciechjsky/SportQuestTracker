using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SportQuestTrackerAPI.Contracts;
using SportQuestTrackerAPI.Data;
using SportQuestTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.Repositories
{
    public class UserRepository//: IUserRepository
    {
        private readonly ApplicationDbContext _db;
        //private readonly RoleManager<IdentityUser> _signInManager;
        //private readonly UserManager<IdentityUser> _userManager;
        public UserRepository(ApplicationDbContext db, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _db = db;
            //_signInManager = signInManager;
            //_userManager = userManager;
        }


        public async Task<IList<User>> FindAll()
        {
            var users = await _db.Users.ToListAsync();
            throw new System.NotImplementedException();
        }

        public async Task<User> FindById(int id)
        {
            var user = await _db.Users.FindAsync(id);
            throw new System.NotImplementedException();
        }

        public async Task<bool> Create(User entity)
        {
            //await _db.Users.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Update(User entity)
        {
            //_db.Users.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(User entity)
        {
            //_db.Users.Remove(entity);
            return await Save();
        }

        //public async Task<bool> IsExists(int id)
        //{
        //    //return await _db.Users.AnyAsync(u => u.Id == id);
        //    //throw new System.NotImplementedException();
        //}

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
    }
}