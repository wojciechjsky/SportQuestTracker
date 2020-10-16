using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportQuestTrackerAPI.Contracts;
using SportQuestTrackerAPI.Data;
using SportQuestTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.Repositories
{
    public class TransactionRepository //:ITransactionRepository
    {
        private readonly ApplicationDbContext _db;

        public TransactionRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        //public async Task<IList<TransactionModel>> FindAll()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public async Task<TransactionModel> FindById(int id)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public async Task<bool> Create(TransactionModel entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public async Task<bool> Update(TransactionModel entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public async Task<bool> Delete(TransactionModel entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task<bool> IsExists(int id)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public async Task<bool> Save()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}