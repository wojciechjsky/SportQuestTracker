using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportQuestTracker.Models;

namespace SportQuestTracker.DTOs
{
    public class GadgetDTO
    {
        public int GadgetId { get; set; }

        public int Price { get; set; }

        public int CompanyId { get; set; }

        public byte Image { get; set; }
    }
}
