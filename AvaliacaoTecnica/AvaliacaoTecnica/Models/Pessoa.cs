using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoTecnica.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

    }
}
