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
        public string Name { get; set; }
        public int Price { get; set; }
        public int CompanyId { get; set; }
        public string Image { get; set; }
        public string Quantity { get; set; }
        public int TypeOfProduct { get; set; }
        public CompanyDTO Company { get; set; }
    }
}
