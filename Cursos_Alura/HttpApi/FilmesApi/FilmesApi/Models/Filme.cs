using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "Campo titulo é obrigatório!" )]
        public string Titulo { get; set; }
        [Required]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1,200)]
        public int Duracao { get; set; }
    }
}
