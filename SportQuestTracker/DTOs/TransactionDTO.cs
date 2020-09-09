using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.DTOs
{
    public class TransactionDTO
    {
        public int TransactionId { get; set; }

        public int UserId { get; set; }

        public int GadgetId { get; set; }

        public DateTime Date { get; set; }
    }
}
