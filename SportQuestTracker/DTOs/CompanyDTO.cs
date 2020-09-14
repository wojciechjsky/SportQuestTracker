using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportQuestTracker.Models;

namespace SportQuestTracker.DTOs
{
    public class CompanyDTO
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int CollectedCoins { get; set; }
        public string Logo { get; set; }
        public IEnumerable<Gadget> Gadgets { get; set; }
        public virtual UserDTO User { get; set; }
    }
}
