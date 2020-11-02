using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTrackerUI.Models
{
    public class Gadget
    {
        //public int GadgetId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

    }
}
