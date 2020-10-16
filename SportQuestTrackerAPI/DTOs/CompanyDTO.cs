using System.Collections.Generic;
using SportQuestTrackerAPI.Data.Models;

namespace SportQuestTrackerAPI.DTOs
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
