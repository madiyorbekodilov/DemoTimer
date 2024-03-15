using DemoTimer.Api.Models;
using DemoTimer.Api.Service.DTOs.OldTimers;
using DemoTimer.Api.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoTimer.Api.Controllers;

public class TimeController : BaseController
{
    private readonly ITimeService timeService;
    public TimeController(ITimeService timeService)
    {
        this.timeService = timeService;
    }
    [HttpPost("create")]
    public async ValueTask<IActionResult> PostAsync([FromHeader] int son)
        => Ok(new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = await this.timeService.
                AddAsync(new TimeCreationDto { SetTime = son, Title=$"77 chi holat"})
        });

    [HttpPost("get-all")]
    public async Task<IActionResult> GetAllAsync()
        => Ok(new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = await this.timeService.RetrieveAllAsync()
        });
}
