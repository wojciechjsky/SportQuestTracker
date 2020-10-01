using System.Collections.Generic;

namespace SportQuestTrackerBlazor.Data.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPassword { get; set; }
        public string CompanyName { get; set; }
        public int CompanyPoints { get; set; }
        public List<Gadget> CompanyGadgets { get; set; }

    }
}