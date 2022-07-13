namespace pokemonAPI.Models
{
    public class Move
    {
        public Guid Id { get; set; }
        public int ActualPP { get; set; }

        public Guid PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Guid MoveTemplateId { get; set; }
        public MoveTemplate MoveTemplate { get; set; }
    }
}
