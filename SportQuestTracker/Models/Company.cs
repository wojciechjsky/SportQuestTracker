using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    [Table("Companies")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public int CollectedCoins { get; set; }

        public string Logo { get; set; }
    }
}
