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
        public virtual Company Company { get; set; }

        public byte Image { get; set; }
        
    }
}
