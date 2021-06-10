using AvaliacaoTecnica.Models;
using AvaliacaoTecnica.Vo;
using System.Collections.Generic;
using System.Linq;

namespace AvaliacaoTecnica.Negocio.Interface
{
    public interface ITarefasNegocio
    {
        List<ArrayArvoreVO> TarefaArrays();
        List<Pessoa> TarefaConsultaSQL();
        IQueryable<Pessoa> ListarPessoa();
        IQueryable<Departamento> ListarDepartamento();
    }
}
