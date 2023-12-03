namespace DemoTimer.Api.Domain.Entities;

public class OldTime : Auditable
{
    public string Title { get; set; }
    public int SetTime { get; set; }
    public int FullTime { get; set; }
}
