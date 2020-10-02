using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportQuestTrackerBlazor.Data.Models
{
    [Table("Companies")]
    public class Company
    {

#nullable disable
        [Key]
        public int CompanyId { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPassword { get; set; }
        public string CompanyName { get; set; }
        public int CompanyPoints { get; set; }
        
        public List<Gadget> CompanyGadgets { get; set; }

        public static string Gadget { get; set; }
    }
}