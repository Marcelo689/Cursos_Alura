using Microsoft.AspNetCore.Authorization;

namespace FilmesAPI
{
    public class IdadeMinimaRequiredment : IAuthorizationRequirement
    {
        public IdadeMinimaRequiredment(int idadeMinima)
        {
            IdadeMinima = idadeMinima;
        }
        public int IdadeMinima { get; set; }
    }
}