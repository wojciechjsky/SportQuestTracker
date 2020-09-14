using System.Collections.Generic;
using System.Threading.Tasks;
using SportQuestTracker.Contracts;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Models.Repositories
{
    public class UserRepository: IUserRepository
    {
        public Task<IList<User>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> FindById(int id)
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