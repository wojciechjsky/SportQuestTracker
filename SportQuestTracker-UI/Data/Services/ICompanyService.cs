using System.Collections.Generic;
using SportQuestTracker.Contracts;
using SportQuestTracker.Models.ClassModels;
using SportQuestTracker_UI.Data.Models.ClassModels;

namespace SportQuestTracker_UI.Data.Services
{
    public interface ICompanyService: IRepositoryBase<Gadget>
    {
        public int ShowSaldo();

        public List<Transaction> ShowTransactions();

    }
}