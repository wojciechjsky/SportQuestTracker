using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SportQuestTracker.Models.ClassModels;
using SportQuestTracker_UI.Data.Models.ClassModels;


namespace SportQuestTracker_UI.Data.Services
{
    public class CompanyService : ICompanyService
    {
        public Task<IList<Gadget>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<Gadget> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(Gadget entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Gadget entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Gadget entity)
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

        public int ShowSaldo()
        {
            throw new NotImplementedException();
        }

        public List<Transaction> ShowTransactions()
        {
            throw new NotImplementedException();
        }
    }
}
