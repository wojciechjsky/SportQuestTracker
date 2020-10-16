using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTrackerAPI.Data.Models
{
    [Table("Users")]
    public class User
    {
        //[Key]
        //public int UserId { get; set; }

        //[Required(ErrorMessage = "Wrong format of email, please try again!")]
        //[DataType(DataType.EmailAddress)]
        //[MaxLength(100)]
        //public string Email { get; set; }
        //[Required(ErrorMessage = "Given password are not the same, please try again!")]
        //[StringLength(100, ErrorMessage = "Given password should have at least 8 characters", MinimumLength = 8)]
        //[DataType(DataType.Password)]
        //[MaxLength(100)]
        //public string Password { get; set; }
        //[Required]
        //[MaxLength(50)]
        //public string FirstName { get; set; }
        //[Required]
        //[MaxLength(50)]
        //public string Surname { get; set; }
        //[Required]
        //public string PhoneNumber { get; set; }


        //public int Points { get; set; } = 0;
        //public int Coins { get; set; } = 0;
        //public bool Admin { get; set; } = false;

    }
}
