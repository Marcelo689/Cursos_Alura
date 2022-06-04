using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pokemons
{
    internal class PokemonConfiguration : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder
                .Property(p => p.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.
                Property(p => p.PokemonTipo)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}