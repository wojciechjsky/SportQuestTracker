using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportQuestTracker.Models.ClassModels
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
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int ParcelNumber { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        [Required]
        public string City { get; set; }

        public int Points { get; set; } = 0;
        public int Coins { get; set; } = 0;
        public bool Admin { get; set; } = false;
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }


    }
}
