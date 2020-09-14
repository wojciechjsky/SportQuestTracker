using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SportQuestTracker.Contracts;

namespace SportQuestTracker.Models
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

        public Gadget GetGadgetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}