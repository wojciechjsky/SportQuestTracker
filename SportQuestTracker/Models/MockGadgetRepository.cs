using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    public class MockGadgetRepository
    {
        public IEnumerable<Gadget> AllCategories => new List<Gadget>()
        {
            new Gadget
            {
                GadgetId = 1,
                Price = 20,
                Company= new Company {
                    CompanyId = 1, CompanyName = "Nike",
                    CollectedCoins = 1200, Logo = "url(NikeLogo.png)"
                },
                Image = "url(Reebook.png)",
                Name="Nike shoes",
                Quantity ="100",
                TypeOfProduct = 1,
            },
            new Gadget
            {
                GadgetId = 2,
                Price = 30,
                Company= new Company {
                    CompanyId = 2, CompanyName = "Adiddas",
                    CollectedCoins = 1000, Logo = "url(AddidasLogo.png)"
                },
                Image = "url(Addidas.png)",
                Name="Addidas shoes",
                Quantity ="100",
                TypeOfProduct = 1,
            },
            new Gadget
            {
                GadgetId = 3, 
                Price = 50,
                Company= new Company {
                    CompanyId = 1, CompanyName = "Reebook",
                    CollectedCoins = 1000, Logo = "url(ReebookLogo.png)"
                },
                Image = "url(Reebook.png)",
                Name="Reebook Shoes",
                Quantity ="100",
                TypeOfProduct = 1,
            },
        };
    }
}