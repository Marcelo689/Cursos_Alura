using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosApi.Data.Dto;
using UsuariosApi.Models;

namespace UsuariosApi
{
    public class ProfileUsuario : Profile
    {
        public ProfileUsuario()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, IdentityUser<int>>();
        }
    }
}
