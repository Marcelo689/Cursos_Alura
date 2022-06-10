using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonRequests.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private PokemonContext _context;
        List<Pokemon> _pokemons = new List<Pokemon>();

        public PokemonController(PokemonContext contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        [Route("Adicionar")]
        public IActionResult Adicionar([FromBody] Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
            Console.WriteLine(pokemon.Nome);
            _context.Pokemon.Add(pokemon);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public Pokemon EncontrarPokemon([FromRoute] int id)
        {
            var pokemon = _context.Pokemon.Find(id);
            return pokemon;
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarPokemon([FromRoute] int id)
        {
            var pokemon = _context.Pokemon.Find(id);
            _context.Pokemon.Remove(pokemon);
            _context.SaveChanges();
            return Ok();
        }
    }
}
