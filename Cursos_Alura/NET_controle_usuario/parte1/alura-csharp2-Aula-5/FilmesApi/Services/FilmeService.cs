using AutoMapper;
using FilmesApi.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesApi.Services
{
    public class FilmeService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public FilmeService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public ReadFilmeDto AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);
            _context.Filmes.Add(filme);
            _context.SaveChanges();

            return _mapper.Map<ReadFilmeDto>(filme);

        }

        public List<ReadFilmeDto> RecuperaFilmes([FromQuery] int? classificacaoEtaria = null)
        {
            List<ReadFilmeDto> readDto = new List<ReadFilmeDto>();
            List<Filme> filmes;
            if (classificacaoEtaria == null)
            {
                filmes = _context.Filmes.ToList();
            }
            else
            {
                filmes = _context
                .Filmes.Where(filme => filme.ClassificacaoEtaria <= classificacaoEtaria).ToList();
            }

            if (filmes != null)
            {
                readDto = _mapper.Map<List<ReadFilmeDto>>(filmes);
                return readDto;
            }
            return readDto;
        }

        public ReadFilmeDto RecuperaFilmesPorId(int id)
        {
            ReadFilmeDto filmeDto = new ReadFilmeDto();
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme != null)
            {
                filmeDto = _mapper.Map<ReadFilmeDto>(filme);

                return filmeDto;
            }
            return filmeDto;
        }

        internal Result DeletaFilme(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null)
                return Result.Fail("Filme não encontrado");
            return Result.Ok();
            _context.Remove(filme);
            _context.SaveChanges();
            
        }

        internal Result AtualizaFilme(int id, UpdateFilmeDto filmeDtoNovo)
        {

            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if( filme == null)
                return Result.Fail("Filme não encontrado!");
            _mapper.Map(filmeDtoNovo, filme);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
