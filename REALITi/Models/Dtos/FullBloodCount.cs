using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class FullBloodCount
{
    [JsonPropertyName("hemoglobin")]
    public double? Hemoglobin { get; set; }

    [JsonPropertyName("hematocrit")]
    public double? Hematocrit { get; set; }

    [JsonPropertyName("whiteBloodCells")]
    public double? WhiteBloodCells { get; set; }

    [JsonPropertyName("platelets")]
    public double? Platelets { get; set; }

    [JsonPropertyName("neutrophils")]
    public double? Neutrophils { get; set; }

    [JsonPropertyName("lymphocytes")]
    public double? Lymphocytes { get; set; }
}