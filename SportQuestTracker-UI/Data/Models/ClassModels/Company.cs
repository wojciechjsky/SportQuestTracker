using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SportQuestTracker_UI.Data.Models.ClassModels;

namespace SportQuestTracker.Models.ClassModels
{
    [Table("Companies")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }

        public int CollectedCoins { get; set; }

        public string Logo { get; set; }

        public IEnumerable<Gadget> Gadgets { get; set; }
        public virtual User User { get; set; }
    }
}
