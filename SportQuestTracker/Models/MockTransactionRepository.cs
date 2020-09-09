using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    public class MockTransactionRepository
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
    }
}
