using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SportQuestTrackerAPI.Data.Models
{
    public class AppUser: IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        public int Points { get; set; } = 0;
        public int Coins { get; set; } = 0;
    }
}
