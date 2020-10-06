using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportQuestTracker.Models.ClassModels;
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

        [HttpPost]
        public string CreateUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return "Save Successfully";
        }


        public List<Gadget> GetAllGadgets()
        {
            var gadgets = _db.Gadgets.ToList();
            return gadgets;
        }
        //public List<Gadget> GetAllGadgets()
        //{
        //    var gadgets = _db.Gadgets.ToList();
        //    return gadgets;
        //}
    }
}
