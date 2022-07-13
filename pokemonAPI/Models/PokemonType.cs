namespace pokemonAPI.Models
{
    public class PokemonType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public List<PokemonTemplate> PokemonTemplates { get; set; }
        public List<MoveTemplate> MoveTemplates { get; set; }
    }
}
