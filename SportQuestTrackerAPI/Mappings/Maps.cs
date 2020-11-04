﻿using AutoMapper;
using SportQuestTrackerAPI.Data.Models;
using SportQuestTrackerAPI.DTOs;

namespace SportQuestTrackerAPI.Mappings
{
    public class Maps: Profile
    {
        public Maps()
        {
            CreateMap<AppUser, RegisterUserDTO>().ReverseMap();
            CreateMap<Gadget, GadgetDTO>().ReverseMap();
            CreateMap<Gadget, GadgetCrudDTO>().ReverseMap();
            CreateMap<Quest, QuestDTO>().ReverseMap();
            CreateMap<TransactionModel, TransactionDTO>().ReverseMap();
            CreateMap<Company, CompanyDTO>().ReverseMap();
        }
    }
}
