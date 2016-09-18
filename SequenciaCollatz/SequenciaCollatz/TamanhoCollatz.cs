using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenciaCollatz
{
    class TamanhoCollatz
    {
        public long Valor { get; set; }
        public long Tamanho { get; set; }
        public TamanhoCollatz(long valor, long tamanho)
        {
            this.Tamanho = tamanho;
            this.Valor = valor;
        }

        public TamanhoCollatz Encontre(long n)
        {
            var valor = n;
            var tamanho = 0;

            while (n != 1)
            {
                if ((n & 1) == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = (3 * n) + 1;
                }
                tamanho += 1;
            }
            return new TamanhoCollatz(valor, tamanho);
        }
    }
}
