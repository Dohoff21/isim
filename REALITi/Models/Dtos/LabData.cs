using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class LabData
{
    [JsonPropertyName("timepoint")]
    public string Timepoint { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("FBC")]
    public FullBloodCount? FBC { get; set; }

    [JsonPropertyName("Chem20")]
    public ChemistryPanel? Chem20 { get; set; }

    [JsonPropertyName("Coags")]
    public CoagulationStudies? Coags { get; set; }

    [JsonPropertyName("ABG")]
    public ArterialBloodGas? ABG { get; set; }

    [JsonPropertyName("BloodCultures")]
    public BloodCultures? BloodCultures { get; set; }

    [JsonPropertyName("additionalTests")]
    public Dictionary<string, object>? AdditionalTests { get; set; }
}
