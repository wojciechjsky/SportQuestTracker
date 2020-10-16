using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTrackerAPI.Data.Models
{
    public class Gadget
    {
        [Key]
        public int GadgetId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        public string Image { get; set; }

        [Required]
        public string Quantity { get; set; }

        [Required]
        public int TypeOfProduct { get; set; }
        public Company Company { get; set; }

    }
}
