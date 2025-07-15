using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class Handover
{
    [JsonPropertyName("time_of_day")]
    public string TimeOfDay { get; set; } = string.Empty;

    [JsonPropertyName("handover_reason")]
    public string HandoverReason { get; set; } = string.Empty;

    [JsonPropertyName("confederate_role")]
    public string ConfederateRole { get; set; } = string.Empty;

    [JsonPropertyName("what_is_about_to_happen")]
    public string WhatIsAboutToHappen { get; set; } = string.Empty;

    [JsonPropertyName("SBAR")]
    public SBAR SBAR { get; set; } = new();
}