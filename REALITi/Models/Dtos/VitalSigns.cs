using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class VitalSigns
{
    [JsonPropertyName("hr")]
    public int? HeartRate { get; set; }

    [JsonPropertyName("bpSys")]
    public int? BloodPressureSystolic { get; set; }

    [JsonPropertyName("bpDia")]
    public int? BloodPressureDiastolic { get; set; }

    [JsonPropertyName("spo2")]
    public int? SpO2 { get; set; }

    [JsonPropertyName("etco2")]
    public int? EtCO2 { get; set; }

    [JsonPropertyName("respRate")]
    public int? RespiratoryRate { get; set; }

    [JsonPropertyName("temp")]
    public double? Temperature { get; set; }

    [JsonPropertyName("ecgWaveform")]
    public int? ECGWaveform { get; set; }

    [JsonPropertyName("bpWaveform")]
    public int? BPWaveform { get; set; }

    [JsonPropertyName("spo2Waveform")]
    public int? SpO2Waveform { get; set; }

    [JsonPropertyName("etco2Waveform")]
    public int? EtCO2Waveform { get; set; }

    [JsonPropertyName("ecgVisible")]
    public bool? ECGVisible { get; set; }

    [JsonPropertyName("bpVisible")]
    public bool? BPVisible { get; set; }

    [JsonPropertyName("spo2Visible")]
    public bool? SpO2Visible { get; set; }

    [JsonPropertyName("etco2Visible")]
    public bool? EtCO2Visible { get; set; }

    [JsonPropertyName("rrVisible")]
    public bool? RRVisible { get; set; }

    [JsonPropertyName("tempVisible")]
    public bool? TempVisible { get; set; }

    [JsonPropertyName("ventilated")]
    public bool? Ventilated { get; set; }

    [JsonPropertyName("spo2Attached")]
    public bool? SpO2Attached { get; set; }
}