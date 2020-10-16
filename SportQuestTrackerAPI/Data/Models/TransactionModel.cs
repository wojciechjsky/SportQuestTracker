using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTrackerAPI.Data.Models
{
    [Table("Transactions")]
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int GadgetId { get; set; }

        [Required]
        public DateTime Date { get; set; }

    }
}
