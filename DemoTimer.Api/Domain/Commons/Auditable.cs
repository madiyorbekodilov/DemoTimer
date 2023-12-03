namespace DemoTimer.Api.Domain.Commons;

public class Auditable
{
    public long Id { get; set; }
    public DateTime StartAt { get; set; } 
    public DateTime EndAt { get; set; } = DateTime.UtcNow;
}