using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportQuestTrackerAPI.Contracts;
using SportQuestTrackerAPI.Data;
using SportQuestTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.Repositories
{
    public class QuestRepository : IQuestRepository
    {
        private readonly ApplicationDbContext _db;

        public QuestRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IList<Quest>> FindAll()
        {
            var quests = await _db.Quests.ToListAsync();
            return quests;
        }

        public async Task<Quest> FindById(int id)
        {
            var quest = await _db.Quests.FindAsync(id);
            return quest;
        }

        public async Task<bool> Create(Quest entity)
        {
            await _db.Quests.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Update(Quest entity)
        {
            _db.Quests.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(Quest entity)
        {
            _db.Quests.Remove(entity);
            return await Save();
        }

        public async Task<bool> IsExists(int id)
        {
            return await _db.Quests.AnyAsync(q => q.Id == id);
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
    }
}
