using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SportQuestTracker.Models.ClassModels;
using SportQuestTracker_UI.Pages.CompanyView;

namespace SportQuestTracker_UI.Data.Models.ClassModels
{
    [Table("Companies")]
    public class Company
    {

#nullable disable
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Points { get; set; }
        [ForeignKey(name: "Gadget")]
        public List<Gadget> CompanyGadgets { get; set; }
        public static string Gadget { get; set; }
    }
}
