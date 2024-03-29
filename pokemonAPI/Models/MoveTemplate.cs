﻿namespace pokemonAPI.Models
{
    public class MoveTemplate
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Category { get; set; }
        public bool AgainstFoe { get; set; }
        public int Accuraty { get; set; }
        public int MaxPP { get; set; }
        public int Power { get; set; }
        public int BuffDefense { get; set; }
        public int BuffSpecialDefence { get; set; }
        public int BuffAttack { get; set; }
        public int BuffSpecialAttack { get; set; }
        public int BuffSpeed { get; set; }
        public int BuffAccuracy { get; set; }
        public int BuffHp { get; set; }

        public List<Move> Moves { get; set; }
        public Guid PokemonTypeId { get; set; }
        public PokemonType PokemonType { get; set; }
        public Status Status { get; set; }
        public Guid StatusId { get; set; }
    }
}
