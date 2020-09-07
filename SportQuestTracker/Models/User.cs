using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    public class User
    {
        [Key] 
        private int UserId { get; set; }
        private string Password { get; set; }
    }
}
