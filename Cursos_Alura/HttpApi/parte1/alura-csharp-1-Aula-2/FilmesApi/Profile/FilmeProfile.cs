using FilmesApi.Dados;
using FilmesApi.Dados.Dto;
using FilmesAPI.Models;

namespace FilmesApi.Profile
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
