using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportQuestTracker.Models.ClassModels
{
    [Table("Companies")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public int CollectedCoins { get; set; }

        public string Password { get; set; }

        public IEnumerable<Gadget> Gadgets { get; set; }
        public virtual User User { get; set; }
    }
}
