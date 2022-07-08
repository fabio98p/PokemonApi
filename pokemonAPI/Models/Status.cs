namespace pokemonAPI.Models
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public List<Pokemon> Pokemons { get; set; }
        public List<Move> Moves { get; set; }
    }
}
