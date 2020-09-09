using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> AllTransactions { get; }
        Transaction GetTransactionById(int id);
    }
}
