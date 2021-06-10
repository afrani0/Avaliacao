using AvaliacaoTecnica.Models;
using AvaliacaoTecnica.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoTecnica.Repositorio.Implementacao
{
    public class TarefasRepositorio : ITarefasRepositorio
    {
        private AplicationDBContext _context;

        public TarefasRepositorio(AplicationDBContext context)
        {
            _context = context;
        }

        public IQueryable<Pessoa> ListarPessoaComDepartamento()
        {
            return _context.Pessoas.Include(p => p.Departamento);
        }

        public IQueryable<Departamento> ListarDepartamento()
        {
            return _context.Departamentos;
        }

        public IQueryable<Pessoa> ListarPessoa()
        {
            return _context.Pessoas;
        }
    }
}
