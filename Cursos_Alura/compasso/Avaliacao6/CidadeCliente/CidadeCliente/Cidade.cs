using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadesCliente
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set;}
        public string Estado { get; set; }
        public int ClienteId { get; set; }
    }

}
