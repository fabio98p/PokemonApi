namespace pokemonAPI
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = String.Empty;
        public List<Character> Characters { get; set; }

    }
}
