using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class ChecklistItem
{
    [JsonPropertyName("action")]
    public string Action { get; set; } = string.Empty;

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("expectedTimeframe")]
    public string ExpectedTimeframe { get; set; } = string.Empty;

    [JsonPropertyName("priority")]
    public string Priority { get; set; } = string.Empty;

    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("value")]
    public int Value { get; set; } = 0;

    [JsonPropertyName("icon")]
    public int Icon { get; set; } = 0;

    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
}