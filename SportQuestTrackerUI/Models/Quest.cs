using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTrackerUI.Models
{
    public class Quest
    {
        public string Name { get; set; }
        public int CoinReward { get; set; }
        public bool IsDone { get; set; }
        public string Image { get; set; }
        //public DateTime DateOfPerformance { get; set; }

    }
}
