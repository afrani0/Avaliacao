using AvaliacaoTecnica.Models;
using AvaliacaoTecnica.Negocio.Interface;
using AvaliacaoTecnica.Repositorio.Interface;
using AvaliacaoTecnica.Vo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AvaliacaoTecnica.Negocio.Implementacao
{
    public class TarefasNegocio : ITarefasNegocio
    {
        private readonly ITarefasRepositorio _tarefasRepositorio;

        public TarefasNegocio(ITarefasRepositorio tarefasRepositorio)
        {
            _tarefasRepositorio = tarefasRepositorio;
        }

        public List<ArrayArvoreVO> TarefaArrays()
        {
            int[] array1 = { 3, 2, 1, 6, 0, 5 };
            int[] array2 = { 7, 5, 13, 9, 1, 6, 4 };

            List<ArrayArvoreVO> arrayArvoreVO = new List<ArrayArvoreVO>();

            arrayArvoreVO.Add(OrganizarArray(array1));
            arrayArvoreVO.Add(OrganizarArray(array2));

            return arrayArvoreVO;
        }

        private ArrayArvoreVO OrganizarArray(int[] array)
        {
            var max = array.Max();

            var arrayArvoreVO = new ArrayArvoreVO() { GalhoDireito = new List<int>(), GalhoEsquerdo = new List<int>() };
            arrayArvoreVO.Raiz = max;

            bool itemNaEsquerda = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    itemNaEsquerda = false;
                }
                else
                {
                    if (itemNaEsquerda == true)
                        arrayArvoreVO.GalhoEsquerdo.Add(array[i]);
                    else
                        arrayArvoreVO.GalhoDireito.Add(array[i]);
                }
            }

            arrayArvoreVO.GalhoDireito = arrayArvoreVO.GalhoDireito.OrderByDescending(x => x).ToList();
            arrayArvoreVO.GalhoEsquerdo = arrayArvoreVO.GalhoEsquerdo.OrderByDescending(x => x).ToList();

            return arrayArvoreVO;
        }

        public List<Pessoa> TarefaConsultaSQL()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            var departamentos = _tarefasRepositorio.ListarDepartamento();

            foreach (var item in departamentos)
            {
                var resultadoMaiorSalario = _tarefasRepositorio.ListarPessoaComDepartamento()
                .Where(x => x.DepartamentoId == item.Id)
                .OrderByDescending(x => x.Salario).FirstOrDefault();

                listaPessoas.Add(resultadoMaiorSalario);
            }

            return listaPessoas;
        }

        public IQueryable<Departamento> ListarDepartamento()
        {
            return _tarefasRepositorio.ListarDepartamento();
        }

        public IQueryable<Pessoa> ListarPessoa()
        {
            return _tarefasRepositorio.ListarPessoa();
        }
    }
}
