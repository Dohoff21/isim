using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class ScenarioEvent
{
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("monitorType")]
    public int MonitorType { get; set; }

    [JsonPropertyName("trendTime")]
    public int TrendTime { get; set; }

    [JsonPropertyName("jumpTime")]
    public int JumpTime { get; set; }

    [JsonPropertyName("defibShock")]
    public bool DefibShock { get; set; }

    [JsonPropertyName("defibDisarm")]
    public bool DefibDisarm { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("parameters")]
    public VitalSigns Parameters { get; set; } = new();

    [JsonPropertyName("relatedChecklist")]
    public List<int> RelatedChecklist { get; set; } = new();

    [JsonPropertyName("relatedLabs")]
    public List<int> RelatedLabs { get; set; } = new();
}