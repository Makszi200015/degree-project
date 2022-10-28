using AutoMapper;
using Degree.BLL.Dtos;
using Degree.DAL.Domain;
using Degree.DataTypes.Enums;

namespace Degree.BLL.AutoMapperProfiles
{
    public class EntitiesAutoMapperProfile : Profile
    {
        public EntitiesAutoMapperProfile()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<AccountInfo, AccountInfoDto>()
                .ForMember(x => x.SocialNetwork, y => y.MapFrom(src => (ESocialNetwork)src.SocialNetwork));
            CreateMap<Advice, AdviceDto>()
                .ForMember(x => x.AdviceType, y => y.MapFrom(src => (EAdviceType)src.AdviceType));
            CreateMap<SearchHistory, SearchHistoryDto>()
                .ForMember(x => x.SocialNetwork, y => y.MapFrom(src => (ESocialNetwork)src.SocialNetwork));
            CreateMap<User, UserDto>();
        }
    }
}
