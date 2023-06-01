using System.Net.Mime;
using System.Text.Json.Serialization;
using System.Windows;
using App_Intro.views;

namespace App_Intro.model;

public class EvolutionProfile
{
    [JsonPropertyName("prev")]
    public string[] Previous { get; set; }
    
    [JsonPropertyName("next")]
    public string[][] Next { get; set; }

    public Pokemon PreviousPokemon => Previous is null ? null : (Application.Current as App).Manager.Pokemons[int.Parse(Previous[0]) - 1];

    private Pokemon[] _getNextPokemons()
    {
        if (Next is null) return null;
        var temp = new Pokemon[Next.Length];

        for (int i = 0; i < Next.Length; i++)
        {
            temp[i] = (Application.Current as App).Manager.Pokemons[int.Parse(Next[i][0]) - 1];
        }

        return temp;
    }

    public Pokemon[] NextPokemons => _getNextPokemons();
}