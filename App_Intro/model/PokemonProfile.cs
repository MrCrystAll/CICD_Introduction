using System.Text.Json.Serialization;

namespace App_Intro.model;

public class PokemonProfile
{
    [JsonPropertyName("height")] public string Height { get; set; }
    
    [JsonPropertyName("weight")] public string Weight { get; set; }

    [JsonPropertyName("egg")] public string[] EggGroups { get; set; }

    [JsonPropertyName("ability")] private string[][] _abilities { get; }

    [JsonPropertyName("gender")] public string GenderProb { get; set; }

    private Ability[] _getAbilities()
    {
        var temp = new Ability[_abilities.Length];

        for (int i = 0; i < _abilities.Length; i++)
        {
            if(bool.TryParse(_abilities[i][0], out bool hidden))
                temp[i] = new Ability(_abilities[i][0], hidden);
        }

        return temp;
    }

    public Ability[] Abilities => _getAbilities();
}