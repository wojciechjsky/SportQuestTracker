using System.Collections.Generic;
using System.Threading.Tasks;
using SportQuestTracker.Contracts;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Models.Repositories
{
    public class GadgetRepository: IGadgetRepository
    {
        public Task<IList<Gadget>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Gadget> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Create<T>(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update<T>(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete<T>(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new System.NotImplementedException();
        }
    }
}