using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportQuestTracker.Models;

namespace SportQuestTracker.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Street { get; set; }
        public int ParcelNumber { get; set; }
        public int HouseNumber { get; set; }
        public string City { get; set; }
        public int Points { get; set; }
        public int Coins { get; set; }

        public virtual GadgetDTO Gadget { get; set; }

        public ICollection<Transaction> UserTransactions { get; set; }
    }
}
