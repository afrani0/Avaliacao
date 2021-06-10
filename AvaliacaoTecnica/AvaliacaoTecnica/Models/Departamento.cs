using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoTecnica.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Pessoa> Pessoas { get; set; }
    }
}
