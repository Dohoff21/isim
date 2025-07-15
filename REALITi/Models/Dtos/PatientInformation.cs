using System.Text.Json.Serialization;

namespace REALITi.Models.Dtos;

public class PatientInformation
{
    [JsonPropertyName("patientName")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("patientAge")]
    public int Age { get; set; }

    [JsonPropertyName("patientSex")]
    public int Sex { get; set; }

    [JsonPropertyName("patientAgeUnit")]
    public string AgeUnit { get; set; } = string.Empty;

    [JsonPropertyName("patientHeight")]
    public int Height { get; set; }

    [JsonPropertyName("patientWeight")]
    public int Weight { get; set; }

    [JsonPropertyName("patientCondition")]
    public string Condition { get; set; } = string.Empty;

    [JsonPropertyName("patientAdmitted")]
    public int AdmittedDays { get; set; }

    [JsonPropertyName("patientPhotoId")]
    public int PhotoId { get; set; }

    // Helper property to convert sex number to readable gender
    public string Gender => Sex switch
    {
        1 => "Male",
        2 => "Female",
        _ => "Unknown"
    };

    // Helper property for medical history (can be extended later)
    public string MedicalHistory { get; set; } = string.Empty;

    // Helper properties for future use
    public List<string> Allergies { get; set; } = new();
    public List<string> Medications { get; set; } = new();
}