﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTrackerUI.Models
{
    [Table("Companies")]
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public List<Gadget> Gadgets { get; set; }
        public static string Gadget { get; set; }

    }
}
