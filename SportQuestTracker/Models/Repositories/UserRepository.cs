using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportQuestTracker.Contracts;
using SportQuestTracker.Data;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Models.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IList<User>> FindAll()
        {
            var users = await _db.Users.ToListAsync();
            return users;
        }

        public async Task<User> FindById(int id)
        {
            var user = await _db.Users.FindAsync(id);
            return user;
        }

        public async Task<bool> Create(User entity)
        {
            await _db.Users.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Update(User entity)
        {
            _db.Users.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(User entity)
        {
            _db.Users.Remove(entity);
            return await Save();
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
    }
}