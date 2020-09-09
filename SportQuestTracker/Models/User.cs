using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportQuestTracker.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Street { get; set; }
        public int ParcelNumber { get; set; }
        public int HouseNumber { get; set; }
        public string City { get; set; }
        public int Points { get; set; }
        public int Coins { get; set; }

        public virtual Gadget Gadget { get; set; }

        public ICollection<Transaction> UserTransactions { get; set; }

        // [ForeignKey("Transactions")] TODO zapytać Piotra czy tam może być lista, czy wtedy musi byc też i nowa tabela?
        // public int HistoryId { get; set; }

    }
}
