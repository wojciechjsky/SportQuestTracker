using System.Collections.Generic;
using System.Threading.Tasks;
using SportQuestTracker.Contracts;
using SportQuestTracker.Models.ClassModels;
using SportQuestTracker_UI.Data.Models.ClassModels;

namespace SportQuestTracker_UI.Data.Services
{
    public interface ICompanyService: IRepositoryBase<Gadget> 
    {
        int ShowSaldo(int points);

         IList<Transaction> ShowTransactions(Transaction entity);

    }
}