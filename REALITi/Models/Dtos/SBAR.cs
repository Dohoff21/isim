using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class SBAR
{
    [JsonPropertyName("situation")]
    public string Situation { get; set; } = string.Empty;

    [JsonPropertyName("background")]
    public string Background { get; set; } = string.Empty;

    [JsonPropertyName("assessment")]
    public string Assessment { get; set; } = string.Empty;

    [JsonPropertyName("recommendation")]
    public string Recommendation { get; set; } = string.Empty;
}