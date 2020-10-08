using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportQuestTracker.Models.ClassModels;
using SportQuestTracker_UI.Data.Models.ClassModels;
using SportQuestTracker_UI.DataBase;



namespace SportQuestTracker_UI.Data.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _db;

        public CompanyService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IList<Gadget>> FindAll()
        {
            var allGadgets = _db.Gadgets.FindAsync();
            return (IList<Gadget>)await allGadgets;
        }

        public async Task<Gadget> FindById(int id)
        {
            var idGadget = await _db.Gadgets.FindAsync(id);
            return idGadget;
        }

        public async Task<bool> Create(Gadget entity)
        {
            await _db.Gadgets.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Update(Gadget entity)
        {
            throw new NotImplementedException();
        }

        // public async Task<bool> Update(Gadget gadget)
        // {
        //     // await _db.Update(gadget);
        //     // return await Save();
        // }

        public async Task<bool> Delete(Gadget entity)
        {
            _db.Gadgets.Remove(entity);
            return await Save();
        }

        public async Task<bool> IsExists(int id)
        {
            var isExists = await _db.Gadgets.AnyAsync(q => q.GadgetId == id);
            return isExists;
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }

        public int ShowSaldo(int points)
        {
            throw new NotImplementedException();
        }

        public IList<Transaction> ShowTransactions(Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
