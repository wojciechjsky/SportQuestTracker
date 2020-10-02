 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using SportQuestTracker.Models.ClassModels;
 using SportQuestTrackerBlazor.Data.Models;

 namespace SportQuestTrackerBlazor.Data
{
    public class CompanyService : ICompanyService
    {
        public async Task<IList<Gadget>> FindAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Gadget> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(Gadget entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(Gadget entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Gadget entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Save()
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
