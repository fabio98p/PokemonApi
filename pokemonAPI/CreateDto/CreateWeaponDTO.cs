namespace pokemonAPI.CreateDto
{
    public class CreateWeaponDTO
    {
        public string Name { get; set; } = String.Empty;
        public int Damage { get; set; } = 10;
        public int CharacterId { get; set; }
    }
}
