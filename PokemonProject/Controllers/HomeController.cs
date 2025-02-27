using Microsoft.AspNetCore.Mvc;
using PokemonProject.Model;
using PokemonProject.Models;
using System.Diagnostics;

namespace PokemonProject.Controllers
{
    public class HomeController : Controller
    {
        // instance of the PokeClient class.
        private readonly PokeClient _client;

        public HomeController(PokeClient client)
        {
            _client = client;
        }

        //logic used to create the pokemon cards on the index.
        public async Task<IActionResult> Index(int? pokemonId, string pokemonType, string stat, int? minStatValue)
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 1; i < 30; i++)
            {
                pokemonList.Add(await _client.GetPokemon(i.ToString()));
            }

            // Filter by ID if provided
            if (pokemonId.HasValue)
            {
                pokemonList = pokemonList
                    .Where(p => p.id == pokemonId.Value)
                    .ToList();
            }

            // Filter by Type if provided
            if (!string.IsNullOrEmpty(pokemonType))
            {
                pokemonList = pokemonList
                    .Where(p => p.types.Any(t => t.type.name.Equals(pokemonType, StringComparison.OrdinalIgnoreCase)))
                    .ToList();
            }

            // Filter by Stats (if both stat type and value are provided)
            if (!string.IsNullOrEmpty(stat) && minStatValue.HasValue)
            {
                pokemonList = pokemonList
                    .Where(p => p.stats.Any(s => s.stat.name.Equals(stat, StringComparison.OrdinalIgnoreCase) && s.base_stat >= minStatValue.Value))
                    .ToList();
            }

            return View(pokemonList);
        }

        public async Task<IActionResult> Details(string searchString)
        {
            var pokemonDetails = new List<Pokemon>();

            if (!string.IsNullOrEmpty(searchString))
            {
                pokemonDetails.Add(await _client.GetPokemon(searchString.ToString()));

            }



            return View(pokemonDetails);
        }
    }
}
