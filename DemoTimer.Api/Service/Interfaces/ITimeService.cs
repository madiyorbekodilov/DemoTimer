using DemoTimer.Api.Service.DTOs.OldTimers;

namespace DemoTimer.Api.Service.Interfaces;

public interface ITimeService
{
    Task<TimeResultDto> AddAsync(TimeCreationDto dto);
    Task<IEnumerable<TimeResultDto>> RetrieveAllAsync();
}
