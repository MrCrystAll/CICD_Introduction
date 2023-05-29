using System.Net.Mime;
using System.Text.Json.Serialization;
using System.Windows;
using App_Intro.views;

namespace App_Intro.model;

public class EvolutionProfile
{
    [JsonPropertyName("prev")]
    private string[] _previous { get; set; }
    
    [JsonPropertyName("next")]
    private string[][] _next { get; set; }

    public Pokemon PreviousPokemon => (Application.Current as App).Manager.Pokemons[int.Parse(_previous[0]) - 1];

    private Pokemon[] _getNextPokemons()
    {
        var temp = new Pokemon[_next.Length];

        for (int i = 0; i < _next.Length; i++)
        {
            temp[i] = (Application.Current as App).Manager.Pokemons[int.Parse(_next[i][0]) - 1];
        }

        return temp;
    }

    public Pokemon[] NextPokemons => _getNextPokemons();
}