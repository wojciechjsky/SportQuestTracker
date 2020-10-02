using System.Collections.Generic;
using System.Threading.Tasks;
using SportQuestTracker.Contracts;
using SportQuestTrackerBlazor.Data.Models;

namespace SportQuestTrackerBlazor.Data
{
    public interface ICompanyService: IRepositoryBase<Gadget>
    {
        public int ShowSaldo();

        public List<Transaction> ShowTransactions();

    }
}