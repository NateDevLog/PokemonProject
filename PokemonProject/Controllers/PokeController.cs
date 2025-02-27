using PokemonProject.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace PokemonProject.Controllers
{
    public class PokeClient
    {
        // Defining logic for the client / pokeclient
        public HttpClient Client { get; set; }
        public PokeClient(HttpClient client)
        {
            this.Client = client;
        }

        // getting the data for the pokemon
        public async Task<Pokemon> GetPokemon(string id)
        {
            // getting data for the specific pokemon from the api
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();

            // returns the deserialized pokemon data to the model.
            return JsonSerializer.Deserialize<Pokemon>(content);
        }


        public async Task<Pokemon> GetPokemonSpecies(string id)
        {
            // getting data for the specific pokemon from the api
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon-species/{id}");
            var content = await response.Content.ReadAsStringAsync();

            // returns the deserialized pokemon data to the model.
            return JsonSerializer.Deserialize<Pokemon>(content);
        }
    }
}