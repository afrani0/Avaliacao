using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoTecnica.Vo
{
    public class ArrayArvoreVO
    {
        public int Raiz { get; set; }
        public List<int> GalhoEsquerdo { get; set; }
        public List<int> GalhoDireito { get; set; }
    }
}
