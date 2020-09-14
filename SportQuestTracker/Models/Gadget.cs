using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    [Table("Gadgets")]
    public class Gadget
    {
        [Key] 
        public int GadgetId { get; set; }

        public int Price { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public string Quantity { get; set; }

        public int TypeOfProduct { get; set; }
        public Company Company { get; set; }

    }
}
