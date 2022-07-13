namespace pokemonAPI.Models
{
    public class PokemonTemplate
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; }
        public float HpLevelMoltiplicator { get; set; }
        public float DefenseLevelMoltiplicator { get; set; }
        public float SpecialDefenseLevelMoltiplicator { get; set; }
        public float AttackLevelMoltiplicator { get; set; }
        public float SpecialAttackLevelMoltiplicator { get; set; }
        public float SpeedLevelMoltiplicator { get; set; }
        public float XpLevelMoltiplicator { get; set; }

        public List<Pokemon> Pokemons { get; set; }
        public List<PokemonType> PokemonType { get; set; }

    }
}
