using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportQuestTracker.DTOs;
using SportQuestTracker.Models;
using SportQuestTracker.Models.ClassModels;

namespace SportQuestTracker.Mappings
{
    public class Maps: Profile
    {
        public Maps()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserCrudDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();
            CreateMap<Gadget, GadgetDTO>().ReverseMap();
            CreateMap<Gadget, GadgetCrudDTO>().ReverseMap();
            CreateMap<Transaction, TransactionDTO>().ReverseMap();
            CreateMap<Company, CompanyDTO>().ReverseMap();
        }
    }
}
