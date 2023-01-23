using AutoMapper;
using DataModels = PlayersAdminPortal.DataModels;
using PlayersAdminPortal.DomainModels;

namespace PlayersAdminPortal.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Player, Player>().ReverseMap();
            CreateMap<DataModels.Gender, Gender>().ReverseMap();
            CreateMap<DataModels.Address, Address>().ReverseMap();
        }
    }
}
