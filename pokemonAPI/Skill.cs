using System.Text.Json.Serialization;

namespace pokemonAPI
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Danage { get; set; }
        [JsonIgnore]
        public List<Character> Characters { get; set; }
    }
}
