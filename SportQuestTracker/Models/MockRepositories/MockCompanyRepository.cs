﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SportQuestTracker.Contracts;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Models.MockRepositories
{
    public class MockCompanyRepository: ICompanyRepository
    {
        public IEnumerable<Company> Companies => new List<Company>()
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

        public IEnumerable<Company> AllCompanies { get; }

        public Task<IList<Company>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Company> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Create(Company entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Company entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(Company entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
