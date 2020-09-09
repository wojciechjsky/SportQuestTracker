using System.Collections.Generic;

namespace SportQuestTracker.Models
{
    public class UserRepository: IUserRepository
    {
        private IUserRepository _userRepositoryImplementation;
        public IEnumerable<User> AllUsers => _userRepositoryImplementation.AllUsers;

        public User GetUserById(int id)
        {
            return _userRepositoryImplementation.GetUserById(id);
        }
    }
}