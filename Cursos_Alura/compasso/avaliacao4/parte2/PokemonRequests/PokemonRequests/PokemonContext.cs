using Microsoft.EntityFrameworkCore;

namespace Pokemons
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> Pokemon { get; set; }
        public PokemonContext(DbContextOptions<PokemonContext> opt) : base (opt)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=Pokemon;user=root;password=root");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
