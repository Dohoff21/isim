using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class CoagulationStudies
{
    [JsonPropertyName("pt")]
    public double? PT { get; set; }

    [JsonPropertyName("inr")]
    public double? INR { get; set; }

    [JsonPropertyName("aptt")]
    public double? APTT { get; set; }

    [JsonPropertyName("fibrinogen")]
    public double? Fibrinogen { get; set; }
}