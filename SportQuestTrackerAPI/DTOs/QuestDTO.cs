using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTrackerAPI.DTOs
{
    public class QuestDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CoinReward { get; set; }
        public bool IsDone { get; set; }
        public string Image { get; set; }
        //public DateTime? DateOfPerformance { get; set; }
    }
}
