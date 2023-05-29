using System.IO;
using System.Text.Json;
using App_Intro.model;

namespace App_Intro;

public static class DataParser
{
    public static Pokemon[] LoadPokemon()
    {
        using StreamReader reader = new StreamReader("data/pokedex.json");
        string json = reader.ReadToEnd();

        var obj = JsonSerializer.Deserialize<Pokemon[]>(json);

        return obj;
    }
}