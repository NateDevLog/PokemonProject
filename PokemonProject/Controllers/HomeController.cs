using Microsoft.AspNetCore.Mvc;
using PokemonProject.Model;
using PokemonProject.Models;
using System.Diagnostics;

namespace PokemonProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly PokeClient _client;

        public HomeController(PokeClient client)
        {
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 1; i < 20; i++)
            {
                pokemonList.Add(await _client.GetPokemon(i.ToString()));
            }

            return View(pokemonList);
        }
    }
}
