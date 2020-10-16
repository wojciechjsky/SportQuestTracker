using AutoMapper;
using SportQuestTrackerAPI.Data.Models;
using SportQuestTrackerAPI.DTOs;

namespace SportQuestTrackerAPI.Mappings
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
            CreateMap<TransactionModel, TransactionDTO>().ReverseMap();
            CreateMap<Company, CompanyDTO>().ReverseMap();
        }
    }
}
