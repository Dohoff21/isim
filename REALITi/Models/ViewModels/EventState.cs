namespace REALITi.Models.ViewModels;

public class EventState
{
    public bool IsActive { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? StartedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
}