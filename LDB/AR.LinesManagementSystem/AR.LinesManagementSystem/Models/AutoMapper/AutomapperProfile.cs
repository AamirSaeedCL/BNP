using AR.LinesManagementSystem.Api.Models.Dto;
using AR.LinesManagementSystem.Models;
using AutoMapper;

namespace AR.LinesManagementSystem.Api.Models.AutoMapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {

            CreateMap<ConnectivityCategory, ConfigurationDto>()
                //.ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
                //.ForMember(d => d.Name, opt => opt.MapFrom(src => src.Name))
                //.ForMember(d => d.Description, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();
            CreateMap<Reason, ReasonDto>().ReverseMap();
        }
    }
}
