﻿namespace pokemonAPI.Models
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public List<MoveTemplate> MoveTemplates { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
