using System.ComponentModel.DataAnnotations;

namespace Pokemons
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string PokemonTipo { get; set; }

    }
}