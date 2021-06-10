using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvaliacaoTecnica.Models;
using AvaliacaoTecnica.Negocio.Implementacao;
using AvaliacaoTecnica.Negocio.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoTecnica.Controllers
{
    public class TarefaController : Controller
    {
        private readonly ITarefasNegocio _negocio;


        public TarefaController(ITarefasNegocio negocio)
        {
            _negocio = negocio;
        }
        // GET: Tarefa

        [HttpGet("/")]
        public ActionResult Tarefas()
        {
            //lista tabela pessoa
            var retornoPessoa = _negocio.ListarPessoa();
            //lista tabela departamento
            var retornoDepartamento = _negocio.ListarDepartamento();
            //resultado pessoa com maior salário por departamento
            var retornoResposta = _negocio.TarefaConsultaSQL();

            ViewBag.Departamento = retornoDepartamento;
            ViewBag.ResultadoTarefa = retornoResposta;

            var retornoArvoreArray = _negocio.TarefaArrays();

            ViewBag.ArrayArvore = retornoArvoreArray;

            return View(retornoPessoa);
        }
        
    }
}