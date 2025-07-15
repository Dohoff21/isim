using REALITi.Models.Dtos;

namespace REALITi.Models.ViewModels;

public class ScenarioViewModel
{
    public Scenario Scenario { get; set; } = new();
    public int CurrentEventIndex { get; set; } = 0;
    public DateTime ScenarioStartTime { get; set; } = DateTime.Now;
    public bool IsLoaded { get; set; }
    public bool IsLoading { get; set; }
    public string? ErrorMessage { get; set; }
    
    public List<EventState> EventStates { get; set; } = new();
}