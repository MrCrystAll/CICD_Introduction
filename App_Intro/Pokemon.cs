using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace App_Intro;

public class Pokemon
{
    private int _id;

    [JsonPropertyName("id")]
    public int Id
    {
        get => _id;
        set
        {
            _id = value;
            Image = "data/images/" + _id.ToString("000") + ".png";
            Thumbnail = "data/thumbnails/" + _id.ToString("000") + ".png";
            Sprite = "data/sprites/" + _id.ToString("000") + "MS.png";
        }
    }
    public string Image { get; set; }
    public string Thumbnail { get; set; }
    public string Sprite { get; set; }
    
    [JsonPropertyName("name")]
    public Name Name { get; set; }
    
    [JsonPropertyName("base")]
    public Stats BaseStats { get; set; }

    [JsonPropertyName("type")]
    public string[] Types { get; set; }
}