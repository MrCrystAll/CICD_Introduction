using System.Text.Json.Serialization;

namespace App_Intro.model;

public class EvolutionProfile
{
    [JsonPropertyName("prev")]
    public string[] Previous { get; set; }
    
    [JsonPropertyName("next")]
    public string[][] Next { get; set; }
}