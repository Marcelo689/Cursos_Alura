using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Controllers
{
    public class SolicitaResetRequest
    {
        [Required]
        public string Email { get; set; }

    }
}