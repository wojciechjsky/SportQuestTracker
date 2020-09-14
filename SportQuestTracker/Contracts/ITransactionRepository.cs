using System.Collections.Generic;
using SportQuestTracker.Models;

namespace SportQuestTracker.Contracts
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> AllTransactions { get; }
        Transaction GetTransactionById(int id);
    }
}
