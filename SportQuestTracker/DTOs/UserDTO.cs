using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SportQuestTracker.Models;

namespace SportQuestTracker.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public int ParcelNumber { get; set; }
        public int HouseNumber { get; set; }
        public string City { get; set; }
        public int Points { get; set; } = 0;
        public int Coins { get; set; } = 0;
        public bool Admin { get; set; } = false;

        public int? CompanyId { get; set; }
        public virtual CompanyDTO Company { get; set; }


    }

    public class UserCreationDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int ParcelNumber { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int Points { get; set; } = 0;
        [Required]
        public int Coins { get; set; } = 0;
        [Required]
        public bool Admin { get; set; } = false;

        public int? CompanyId { get; set; }
    }
}
