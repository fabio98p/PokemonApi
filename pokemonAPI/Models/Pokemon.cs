namespace pokemonAPI.Models
{
    public class Pokemon
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int MaxHp { get; set; }
        public int Actual_Hp { get; set; }
        public int Defense { get; set; }
        public int Special_Defense { get; set; }
        public int Attack { get; set; }
        public int Special_Attack { get; set; }
        public int Speed { get; set; }
        public int Actual_Xp { get; set; }
        public int NewLevelXp { get; set; }
        public int Avoidance { get; set; }
        public int ActualAvoidance { get; set; }

        public List<Type> Types { get; set; }
        public List<Move> Moves { get; set; }
        public Status Status { get; set; }
        public Guid StatusId { get; set; }
    }
}
