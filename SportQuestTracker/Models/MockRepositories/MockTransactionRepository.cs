using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SportQuestTracker.Contracts;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Models.MockRepositories
{
    public class MockTransactionRepository :ITransactionRepository
    {
        public IEnumerable<Transaction> AllCategories => new List<Transaction>()
        {
            new Transaction {
                TransactionId =  1, UserId = 2, GadgetId = 2, 
                Date = new DateTime(2020, 09, 12, 11,50,33)
            },
            new Transaction {
                TransactionId =  1, UserId = 2, GadgetId = 2, 
                Date = new DateTime(2020, 11, 14, 07,52,21)
            },
            new Transaction {
                TransactionId =  1, UserId = 2, GadgetId = 2,
                Date = new DateTime(2020, 04, 27, 21,33,13)
            },
        };

        public Task<IList<Transaction>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}
