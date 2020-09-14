using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IList<T>> FindAll();
        Task<T> FindById(int id);
        Task<bool> Create<TEntity>(TEntity entity);
        Task<bool> Update<TEntity>(TEntity entity);
        Task<bool> Delete<TEntity>(TEntity entity);
        Task<bool> Save();

    }
}
