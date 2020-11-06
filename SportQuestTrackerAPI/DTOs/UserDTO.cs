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
    public class RegisterUserDTO
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Your FirstName is limited to {2} to {1} characters", MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Your LastName is limited to {2} to {1} characters", MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [StringLength(9, ErrorMessage = "Your LastName is limited to {2} to {1} characters", MinimumLength = 9)]
        public string Phone { get; set; }

    }
    public class AppUserDTO
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Your FirstName is limited to {2} to {1} characters", MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Your LastName is limited to {2} to {1} characters", MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [StringLength(9, ErrorMessage = "Your LastName is limited to {2} to {1} characters", MinimumLength = 9)]
        public string Phone { get; set; }

    }
}
