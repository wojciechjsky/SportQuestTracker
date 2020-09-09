﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    public class MockCompanyRepository
    {
        public IEnumerable<Company> AllCategories => new List<Company>()
        {
            new Company {
                CompanyId = 1, CompanyName = "Nike", CollectedCoins = 1000, Logo = "url(Nike.png)"
            },
            new Company
            {
                CompanyId = 2, CompanyName = "Adidas", CollectedCoins = 2000, Logo = "url(Adidas.png)"
            },
            new Company
            {
                CompanyId = 3, CompanyName = "Reebook", CollectedCoins = 550, Logo = "url(Reebook.png)"
            },
        };
    }
}
