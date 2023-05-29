using System.Text.Json.Serialization;

namespace App_Intro.model;

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
            Image = "../data/images/" + _id.ToString("000") + ".png";
            Thumbnail = "../data/thumbnails/" + _id.ToString("000") + ".png";
            Sprite = "../data/sprites/" + _id.ToString("000") + "MS.png";
        }
    }
    public string Image { get; set; }
    public string Thumbnail { get; set; }
    public string Sprite { get; set; }
    
    [JsonPropertyName("name")]
    public Name Name { get; set; }
    
    [JsonPropertyName("base")]
    public Stats BaseStats { get; set; }

    private string[] _types;

    [JsonPropertyName("type")]
    public string[] Types
    {
        get => _types;
        set
        {
            _types = value;
            for (int i = 0; i < _types.Length; i++)
            {
                TypesSprites[i] = $"../data/types_sprites/{_types[i]}.png";
            }
        }
    }

    public string[] TypesSprites { get; set; } = new string[2];

    [JsonPropertyName("species")] public string Species { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("evolution")] public EvolutionProfile Evolution { get; set; }
    [JsonPropertyName("profile")] public PokemonProfile Profile { get; set; }
    
}