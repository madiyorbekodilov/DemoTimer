using AutoMapper;
using DemoTimer.Api.Domain.Entities;
using DemoTimer.Api.Service.DTOs.OldTimers;

namespace DemoTimer.Api.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<OldTime, TimeResultDto>().ReverseMap();
        CreateMap<TimeCreationDto, OldTime>().ReverseMap();
    }
}
