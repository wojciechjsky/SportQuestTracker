using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Gadget")]
        public int GadgetId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public virtual Gadget Gadget { get; set; }
    }
}
