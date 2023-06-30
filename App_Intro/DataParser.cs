using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using App_Intro.model;

namespace App_Intro;

public static class DataParser
{
    private static HttpClient _client = new HttpClient();
    public static Pokemon[] LoadPokemon()
    {
        using StreamReader reader = new StreamReader("data/pokedex.json");
        string json = reader.ReadToEnd();

        var obj = JsonSerializer.Deserialize<Pokemon[]>(json);

        return obj;
    }

    public static async Task<Pokemon?> GetPokemon(string id)
    {
        var response = await _client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + id);
        Stream stream = response.Content.ReadAsStream();
        using StreamReader sr = new StreamReader(stream);

        return JsonSerializer.Deserialize<Pokemon>(await sr.ReadToEndAsync());
    }
}