using System.Collections.Generic;
using System.Linq;

namespace App_Intro;

public class Manager
{
    public List<Pokemon> Pokemons { get; set; } = DataParser.LoadPokemon().ToList();
    public Pokemon SelectedPokemon { get; set; }
}