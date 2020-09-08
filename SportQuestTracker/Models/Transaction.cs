using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Gadget")]
        public int GadgetId { get; set; }

        public DateTime Date { get; set; }
    }
}
