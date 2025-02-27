namespace PokemonProject.Model
{
    // the basic data for the pokemon
    public class Pokemon
    {
        public int id { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Sprites sprites { get; set; }
        public List<Stat> stats { get; set; }
        public List<pokeType> types { get; set; }

        // will not work yet, see PokeController.
        public string flavor_text { get; set; }
    }
}
