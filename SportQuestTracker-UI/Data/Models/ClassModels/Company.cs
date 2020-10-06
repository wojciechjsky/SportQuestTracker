using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker_UI.Data.Models.ClassModels
{
    [Table("Companies")]
    public class Company
    {

#nullable disable
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public List<Gadget> CompanyGadgets { get; set; }
        public static string Gadget { get; set; }
    }
}
