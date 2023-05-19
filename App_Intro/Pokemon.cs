using System.Text.Json.Serialization;

namespace App_Intro;

public class Pokemon
{
    [JsonPropertyName("name")]
    public Name Name { get; set; }
}