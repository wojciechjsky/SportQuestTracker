using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportQuestTracker.Contracts;
using SportQuestTracker.Data;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Models.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IList<Company>> FindAll()
        {
            var companies = await _db.Companies.ToListAsync();
            return companies;
        }

        public async Task<Company> FindById(int id)
        {
            var company = await _db.Companies.FindAsync(id);
            return company;
        }

        public async Task<bool> Create(Company entity)
        {
            await _db.Companies.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Update(Company entity)
        {
            _db.Companies.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(Company entity)
        {
            _db.Companies.Remove(entity);
            return await Save();
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
    }
}