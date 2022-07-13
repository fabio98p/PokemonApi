using Microsoft.EntityFrameworkCore;
using pokemonAPI.Models;

namespace pokemonAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Skill> Skills { get; set; }

        //pokemonGameModel
        public DbSet<Move> Moves { get; set; }
        public DbSet<MoveTemplate> MoveTemplates { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonTemplate> PokemonTemplates { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Pokemon>()
                            .HasMany(s => s.Moves)
                            .WithOne(s => s.Pokemon)
                            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
