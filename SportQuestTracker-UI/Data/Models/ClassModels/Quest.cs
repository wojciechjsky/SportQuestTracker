using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker_UI.Data.Models.ClassModels
{
    public class Quest
    {
        [Key]
        public int Id{ get; set; }
        public string Name{ get; set; }
        public int CoinReward{ get; set; }
        public bool IsDone{ get; set; }
        public DateTime? DateOfPerformance { get; set; }
    }
}
