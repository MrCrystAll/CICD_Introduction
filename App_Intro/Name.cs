using System.Text.Json.Serialization;

namespace App_Intro;

public class Name
{
    [JsonPropertyName("english")]
    public string English { get; set; }
    
    [JsonPropertyName("chinese")]
    public string Chinese { get; set; }
    
    [JsonPropertyName("japanese")]
    public string Japanese { get; set; }
    
    [JsonPropertyName("french")]
    public string French { get; set; }
}