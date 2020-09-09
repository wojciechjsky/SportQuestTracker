using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportQuestTracker.DTOs;
using SportQuestTracker.Models;

namespace SportQuestTracker.Mappings
{
    public class Maps: Profile
    {
        public Maps()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Gadget, GadgetDTO>().ReverseMap();
            CreateMap<Transaction, TransactionDTO>().ReverseMap();
            CreateMap<Company, CompanyDTO>().ReverseMap();
        }
    }
}
