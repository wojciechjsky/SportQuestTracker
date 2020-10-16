using Microsoft.EntityFrameworkCore;
using SportQuestTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.Contracts
{
    public interface ITransactionRepository : IRepositoryBase<TransactionModel>
    {
    }
}
