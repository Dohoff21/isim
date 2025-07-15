using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class ChemistryPanel
{
    [JsonPropertyName("sodium")]
    public double? Sodium { get; set; }

    [JsonPropertyName("potassium")]
    public double? Potassium { get; set; }

    [JsonPropertyName("chloride")]
    public double? Chloride { get; set; }

    [JsonPropertyName("urea")]
    public double? Urea { get; set; }

    [JsonPropertyName("creatinine")]
    public double? Creatinine { get; set; }

    [JsonPropertyName("glucose")]
    public double? Glucose { get; set; }

    [JsonPropertyName("albumin")]
    public double? Albumin { get; set; }

    [JsonPropertyName("bilirubin")]
    public double? Bilirubin { get; set; }

    [JsonPropertyName("alt")]
    public double? ALT { get; set; }

    [JsonPropertyName("ast")]
    public double? AST { get; set; }
}