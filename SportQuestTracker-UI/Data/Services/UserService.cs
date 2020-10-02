using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportQuestTracker_UI.Data.Models.ClassModels;
using SportQuestTracker_UI.DataBase;

namespace SportQuestTracker_UI.Data.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _db;

        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }

        public string CreateUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return "Save Successfully";
        }

    }
}
