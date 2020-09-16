using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SportQuestTracker.Contracts;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Models.MockRepositories
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> Users => new List<User>()
        {
            new User { 
                UserId = 1, Email = "pati@wp.pl", Password = "Large" , FirstName = "Patrycja",
                Surname = "Kowalska", Street ="Mickiewicza", ParcelNumber = 12, HouseNumber = 33,
                City = "Radom", Points = 30, Coins = 30, Admin = true, //CompanyId = 1

            },
            new User
            {
                UserId = 2, Email = "wojti@wp.pl", Password = "Medium", FirstName = "Wojciech", 
                Surname = "Nowak", Street ="Slowackiego", ParcelNumber = 2, HouseNumber = 11, 
                City = "Sandomierz", Points = 20, Coins = 20, Admin = false, //CompanyId = 2
            },
            new User
            {
                UserId = 3, Email = "baksiu@wp.pl", Password = "Small" , FirstName = "Baksiu",
                Surname = "Baksiowski", Street ="Taneczna", ParcelNumber = 3, HouseNumber = 11,
                City = "Warszawa", Points = 110, Coins = 110, Admin = false, //CompanyId = 3
            },
        };


        public Task<IList<User>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}
