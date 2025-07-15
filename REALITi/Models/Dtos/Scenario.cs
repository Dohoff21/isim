using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class Scenario
{
    [JsonPropertyName("scenarioId")]
    public string ScenarioId { get; set; } = string.Empty;

    [JsonPropertyName("scenarioType")]
    public string ScenarioType { get; set; } = string.Empty;

    [JsonPropertyName("scenarioVersion")]
    public int ScenarioVersion { get; set; }

    [JsonPropertyName("scenarioName")]
    public string ScenarioName { get; set; } = string.Empty;

    [JsonPropertyName("scenarioTime")]
    public int ScenarioTime { get; set; }

    [JsonPropertyName("isDemo")]
    public bool IsDemo { get; set; }

    [JsonPropertyName("isALSILegacy")]
    public bool IsALSILegacy { get; set; }

    [JsonPropertyName("scenarioMonitorType")]
    public int ScenarioMonitorType { get; set; }

    [JsonPropertyName("intended_participants")]
    public List<string> IntendedParticipants { get; set; } = new();

    [JsonPropertyName("purpose")]
    public string Purpose { get; set; } = string.Empty;

    [JsonPropertyName("scenario_overview")]
    public string ScenarioOverview { get; set; } = string.Empty;

    [JsonPropertyName("learning_objectives")]
    public List<string> LearningObjectives { get; set; } = new();

    [JsonPropertyName("required_simulation_tools")]
    public List<string> RequiredSimulationTools { get; set; } = new();

    [JsonPropertyName("debriefing_points")]
    public List<string> DebriefingPoints { get; set; } = new();

    [JsonPropertyName("handover")]
    public Handover Handover { get; set; } = new();

    [JsonPropertyName("scenarioEvents")]
    public List<ScenarioEvent> ScenarioEvents { get; set; } = new();

    [JsonPropertyName("patientInformation")]
    public PatientInformation PatientInformation { get; set; } = new();

    [JsonPropertyName("labs")]
    public List<LabData> Labs { get; set; } = new();

    [JsonPropertyName("checklist")]
    public List<ChecklistItem> Checklist { get; set; } = new();
}