using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportQuestTracker.Models.ClassModels
{
    [Table("Transactions")]
    public class Transaction
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
