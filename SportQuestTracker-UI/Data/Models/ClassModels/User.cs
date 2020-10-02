using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportQuestTracker_UI.Data.Models.ClassModels
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(100)]
        public string Password1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required] 
        public string PhoneNumber { get; set; }

        public int Points { get; set; } = 0;
        public int Coins { get; set; } = 0;
        public bool Admin { get; set; } = false;


    }
}
