using System.Collections.Generic;

namespace SportQuestTracker.Models
{
    public class CompanyRepository: ICompanyRepository
    {
        public IEnumerable<Company> AllCompanies { get; }
        public Company GetGadgetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}