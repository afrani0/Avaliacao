using AvaliacaoTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoTecnica.Repositorio.Interface
{
    public interface ITarefasRepositorio
    {
        IQueryable<Pessoa> ListarPessoa();
        IQueryable<Pessoa> ListarPessoaComDepartamento();
        IQueryable<Departamento> ListarDepartamento();
    }
}
