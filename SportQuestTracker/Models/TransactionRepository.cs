using System.Collections.Generic;
using SportQuestTracker.Contracts;

namespace SportQuestTracker.Models
{
    public class TransactionRepository: ITransactionRepository
    {
        private ITransactionRepository _transactionRepositoryImplementation;
        public IEnumerable<Transaction> AllTransactions => _transactionRepositoryImplementation.AllTransactions;

        public Transaction GetTransactionById(int id)
        {
            return _transactionRepositoryImplementation.GetTransactionById(id);
        }
    }
}