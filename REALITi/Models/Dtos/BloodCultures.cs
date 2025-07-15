using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class BloodCultures
{
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("organism")]
    public string Organism { get; set; } = string.Empty;

    [JsonPropertyName("sensitivity")]
    public string Sensitivity { get; set; } = string.Empty;

    [JsonPropertyName("timeToPositivity")]
    public string TimeToPositivity { get; set; } = string.Empty;
}