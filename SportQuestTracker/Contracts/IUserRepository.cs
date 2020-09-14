using System.Collections.Generic;
using SportQuestTracker.Models;

namespace SportQuestTracker.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }
        User GetUserById(int id);
    }
}
