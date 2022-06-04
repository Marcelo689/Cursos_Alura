using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Pokemons
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private IRepository<Pokemon> _repo;
        public PokemonController(IRepository<Pokemon> repository)
        {
            _repo = repository;
        }

        //[HttpGet]
        //public IActionResult ListarPokemons()
        //{
        //    _repo.All
        //}
    }
}
