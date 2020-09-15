using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SportQuestTracker.Contracts;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Models.MockRepositories
{
    public class MockGadgetRepository : IGadgetRepository
    {
        public IEnumerable<Gadget> Gadgets => new List<Gadget>()
        {
            new Gadget
            {
                GadgetId = 1,
                Price = 20,
                CompanyId = 3,
                Image = "url(Reebook.png)",
                Name="Nike shoes",
                Quantity ="100",
                TypeOfProduct = 1,
            },
            new Gadget
            {
                GadgetId = 2,
                Price = 30,
                CompanyId = 1,
                Image = "url(Addidas.png)",
                Name="Addidas shoes",
                Quantity ="100",
                TypeOfProduct = 1,
            },
            new Gadget
            {
                GadgetId = 3, 
                Price = 50,
                CompanyId = 2,
                Image = "url(Reebook.png)",
                Name="Reebook Shoes",
                Quantity ="100",
                TypeOfProduct = 1,
            },
        };

        public IEnumerable<Gadget> AllGadgets { get; }

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

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}