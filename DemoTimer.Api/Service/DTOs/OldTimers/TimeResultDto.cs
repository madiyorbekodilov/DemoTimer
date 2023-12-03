namespace DemoTimer.Api.Service.DTOs.OldTimers;

public class TimeResultDto
{
    public string Title { get; set; }
    public int SetTime { get; set; }
    public DateTime StartAt { get; set; } 
    public DateTime EndAt { get; set; }
}