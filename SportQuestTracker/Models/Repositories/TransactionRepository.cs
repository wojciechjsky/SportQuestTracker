using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportQuestTracker.Contracts;
using SportQuestTracker.Data;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Models.Repositories
{
    public class TransactionRepository: ITransactionRepository
    {
        private readonly ApplicationDbContext _db;

        public TransactionRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IList<Transaction>> FindAll()
        {
            var transactions = await _db.Transactions.ToListAsync();
            return transactions;
        }

        public async Task<Transaction> FindById(int id)
        {
            var transaction = await _db.Transactions.FindAsync(id);
            return transaction;
        }

        public async Task<bool> Create(Transaction entity)
        {
            await _db.Transactions.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Update(Transaction entity)
        {
            _db.Transactions.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(Transaction entity)
        {
            _db.Transactions.Remove(entity);
            return await Save();
        }

        public Task<bool> IsExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
    }
}