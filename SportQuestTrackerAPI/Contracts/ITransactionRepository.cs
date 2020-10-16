using Microsoft.EntityFrameworkCore;

namespace SportQuestTrackerAPI.Contracts
{
    public interface ITransactionRepository : IRepositoryBase<DbLoggerCategory.Database.Transaction>
    {
    }
}
