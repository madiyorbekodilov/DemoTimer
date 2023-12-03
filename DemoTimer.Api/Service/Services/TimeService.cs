using AutoMapper;
using DemoTimer.Api.Domain.Entities;
using DemoTimer.Api.Service.DTOs.OldTimers;
using DemoTimer.Api.Service.Interfaces;
using DemoTimer.Api.Data.IRepasitories;

namespace DemoTimer.Api.Service.Services;

public class TimeService : ITimeService
{
    private readonly IMapper mapper;
    private readonly IRepasitory<OldTime> repasitory;
    public TimeService(IMapper mapper, IRepasitory<OldTime> repasitory)
    {
        this.mapper = mapper;
        this.repasitory = repasitory;
    }
    public async Task<TimeResultDto> AddAsync(TimeCreationDto dto)
    {
        var mappedUser = mapper.Map<OldTime>(dto);
        await this.repasitory.CreateAsync(mappedUser);
        var response = mapper.Map<TimeResultDto>(mappedUser);
        return response;
    }

    public async Task<IEnumerable<TimeResultDto>> RetrieveAllAsync()
    {
        var AllTime = this.repasitory.SelectAll().AsEnumerable();
        var response = mapper.Map<List<TimeResultDto>>(AllTime);
        return response;
    }
}
