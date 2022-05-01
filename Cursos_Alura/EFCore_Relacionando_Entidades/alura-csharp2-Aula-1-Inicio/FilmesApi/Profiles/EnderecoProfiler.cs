using AutoMapper;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class EnderecoProfiler : Profile
    {
        public EnderecoProfiler()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
