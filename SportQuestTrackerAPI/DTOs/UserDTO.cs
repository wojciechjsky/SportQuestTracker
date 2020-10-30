using System.ComponentModel.DataAnnotations;

namespace SportQuestTrackerAPI.DTOs
{
    public class UserDTO
    {
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(50,ErrorMessage = "Your password is limited from 8 to 50 characters", MinimumLength = 8)]
        public string Password { get; set; }

        //[Required]
        //[StringLength(30,ErrorMessage = "Your first name is limited to 30 characters" )]
        //public string FirstName { get; set; }
        //[Required]
        //[StringLength(30, ErrorMessage = "Your surname is limited to 30 characters")]
        //public string Surname { get; set; }

        //[Required]
        //public string PhoneNumber { get; set; }

    }
}
