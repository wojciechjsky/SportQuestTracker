using System;

namespace SportQuestTrackerAPI.DTOs
{
    public class TransactionDTO
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public int GadgetId { get; set; }
        public DateTime Date { get; set; }

    }
}
