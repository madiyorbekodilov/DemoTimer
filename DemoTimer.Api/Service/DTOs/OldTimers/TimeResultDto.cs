namespace DemoTimer.Api.Service.DTOs.OldTimers;

public class TimeResultDto
{
    public string Title { get; set; }
    public int SetTime { get; set; }
    public int FullTime { get; set; }
    public DateTime CreateAt { get; set; } 
    public DateTime EndAt { get; set; }
}