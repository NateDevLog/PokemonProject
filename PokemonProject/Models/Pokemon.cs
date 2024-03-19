namespace BlazorProjectAttemp2.Model
{
    public class Pokemon
    {
        public int height { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Sprites sprites { get; set; }
        public List<Stat> stats { get; set; }
        public List<pokeType> types { get; set; }
    }
}
