using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.DTOs
{
    public class CompanyDTO
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public int CollectedCoins { get; set; }

        public byte Logo { get; set; }
    }
}
