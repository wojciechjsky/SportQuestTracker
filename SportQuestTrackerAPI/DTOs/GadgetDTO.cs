using System.ComponentModel.DataAnnotations;

namespace SportQuestTrackerAPI.DTOs
{
    public class GadgetDTO
    {
        public int GadgetId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CompanyId { get; set; }
        public string Image { get; set; }
        public string Quantity { get; set; }
        public int TypeOfProduct { get; set; }
        public CompanyDTO Company { get; set; }
    }
    public class GadgetCrudDTO
    {
        [Required]
        public int GadgetId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        //[Required]
        public int? CompanyId { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Quantity { get; set; }
        [Required]
        public int TypeOfProduct { get; set; }
        //public CompanyDTO Company { get; set; }
    }
}
