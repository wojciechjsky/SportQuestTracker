using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportQuestTrackerAPI.Contracts;
using SportQuestTrackerAPI.Data;
using SportQuestTrackerAPI.Data.Models; //using SportAppUserTrackerAPI.Contracts;
//using SportAppUserTrackerAPI.Data;
//using SportAppUserTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IList<AppUser>> FindAll()
        {
            var AppUsers = await _db.Users.ToListAsync();
            return AppUsers;
        }

        public async Task<AppUser> FindById(int id)
        {
            var AppUser = await _db.Users.FindAsync(id);
            return AppUser;
        }

        public async Task<bool> Create(AppUser entity)
        {
            await _db.Users.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Update(AppUser entity)
        {
            _db.Users.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(AppUser entity)
        {
            _db.Users.Remove(entity);
            return await Save();
        }

        public Task<bool> IsExists(int id)
        {
            throw new System.NotImplementedException();
        }
        public async Task<bool> IsExists(string email)
        {
            return await _db.Users.AnyAsync(q => q.Email == email);
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
    }
}