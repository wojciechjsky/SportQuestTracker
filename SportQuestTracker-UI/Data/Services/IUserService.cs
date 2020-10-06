using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportQuestTracker_UI.Data.Models.ClassModels;

namespace SportQuestTracker_UI.Data.Services
{
    public interface IUserService
    {
        public string CreateUser(User user);
        public List<Gadget> GetAllGadgets();
        public List<Quest> GetQuests();
    }
}
