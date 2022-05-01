using FilmesApi.Dados;
using FilmesApi.Dados.Dto;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        public FilmeController(FilmeContext contexto)
        {
            _context = contexto;
        }


        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {

            Filme filme = new Filme()
            {
                Titulo = filmeDto.Titulo,
                Diretor = filmeDto.Diretor,
                Genero = filmeDto.Genero,
                Duracao = filmeDto.Duracao,
            };

            //_context.Add(filme);
            //_context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarFilmePorId), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            return _context.Filmes;
        }


        [HttpGet("{id}")]
        public IActionResult RecuperarFilmePorId(int id, [FromBody] ReadFilmeDto filmedto)
        {
            Filme filme = _context.Filmes.FirstOrDefault(f => f.Id == id);
            if (filme != null)
            {

                ReadFilmeDto filmeDto = new ReadFilmeDto();

                filme.Titulo = filmedto.Titulo;
                filme.Diretor = filmedto.Genero;
                filme.Genero = filmedto.Genero;
                filme.Genero = filmedto.Diretor;
                _context.SaveChanges();

                return Ok(filme);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarFilmePorId(int id,[FromBody]Filme filmeNovo)
        {
            Filme filme = _context.Filmes.FirstOrDefault(f => f.Id == id);
            if (filme == null)
            {
                return NotFound();
            }

            filme.Id = filmeNovo.Id;
            filme.Diretor = filmeNovo.Diretor;
            filme.Genero  = filmeNovo.Genero;
            filme.Duracao = filmeNovo.Duracao;
            filme.Titulo  = filmeNovo.Titulo;
            _context.SaveChanges();
            return Ok(filme);;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFilme(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(f => f.Id == id);
            _context.Remove(filme);
            _context.SaveChanges();

            return NoContent();
            
        }
    }
}
