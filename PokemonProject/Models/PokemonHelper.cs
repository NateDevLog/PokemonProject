using Microsoft.AspNetCore.Mvc;
using PokemonProject.Model;
using System.Drawing;

namespace PokemonProject.Models
{
    public static class PokemonHelper
    {
        public static string GetBackgroundColor(string type)
        {
            string color = type switch
            {
                "fire" => "red",
                "water" => "blue",
                "grass" => "green",
                "poison" => "purple",
                "flying" => "skyblue",
                "rock" => "burlywood",
                "ground" => "brown",
                "fighting" => "crimson",
                "electric" => "#C2CC02",
                "normal" => "olive",
                "ice" => "paleturquoise",
                "psychic" => "palevioletred",
                "bug" => "yellowgreen",
                "dark" => "darkslateblue",
                "steel" => "slategray",
                "fairy" => "plum",
                "stellar" => "steelblue",
                "ghost" => "royalblue",
                "dragon" => "cornflowerblue",

                null => "grey"

            };
            return color;
        }

        public static string GetStatColor(string stat)
        {
            string statColor = stat switch
            {
                "hp" => "crimson",
                "attack" => "red",
                "defense" => "blue",
                "special-attack" => "mediumvioletred",
                "special-defense" => "mediumslateblue",
                "speed" => "#FEE12B",

                null => "grey"

            };
            return statColor;
        }

        public static double GetPokemonHeight(int height)
        {
            return Convert.ToDouble(height) / 10;
        }

        public static double GetPokemonWeight(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}