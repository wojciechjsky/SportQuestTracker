using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportQuestTrackerAPI.Contracts;
using SportQuestTrackerAPI.Data;
using SportQuestTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.Repositories
{
    public class GadgetRepository: IGadgetRepository
    {
        private readonly ApplicationDbContext _db;

        public GadgetRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IList<Gadget>> FindAll()
        {
            var gadgets = await _db.Gadgets.ToListAsync();
            return gadgets;
        }

        public async Task<Gadget> FindById(int id)
        {
            var gadget = await _db.Gadgets.FindAsync(id);
            return gadget;
        }

        public async Task<bool> Create(Gadget entity)
        {
            await _db.Gadgets.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Update(Gadget entity)
        {
            _db.Gadgets.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(Gadget entity)
        {
            _db.Gadgets.Remove(entity);
            return await Save();
        }

        public async Task<bool> IsExists(int id)
        {
            return await _db.Gadgets.AnyAsync(q => q.GadgetId== id);
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
    }
}