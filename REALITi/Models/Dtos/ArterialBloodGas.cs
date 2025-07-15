using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class ArterialBloodGas
{
    [JsonPropertyName("ph")]
    public double? pH { get; set; }

    [JsonPropertyName("pco2")]
    public double? PCO2 { get; set; }

    [JsonPropertyName("po2")]
    public double? PO2 { get; set; }

    [JsonPropertyName("hco3")]
    public double? HCO3 { get; set; }

    [JsonPropertyName("baseExcess")]
    public double? BaseExcess { get; set; }

    [JsonPropertyName("lactate")]
    public double? Lactate { get; set; }
}