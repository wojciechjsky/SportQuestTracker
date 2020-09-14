using System.Collections.Generic;
using SportQuestTracker.Models;

namespace SportQuestTracker.Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> AllCompanies
        {
            get;
        }
    }
}
