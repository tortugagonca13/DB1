using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaCollatz
{
    public class TamanhoCollatz : IComparable<TamanhoCollatz>
    {
        /// <summary>
        /// Varíavel local publica para armazenar o valor da sequencia.
        /// </summary>
        public long Valor { get; set; }
        /// <summary>
        /// Varíavel local publica para armazenar o tamanho da sequência de colats
        /// </summary>
        public long Tamanho { get; set; }

        /// <summary>
        /// Varíavel para referencia a classe de calculos.
        /// </summary>
        //public virtual CalculoSequencia Calculo { get; set; }

        /// <summary>
        /// Método para encontrar o maior numero possível da sequencia. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public TamanhoCollatz Encontre(long n)
        {
            var valor = n;
            var tamanho = 0;

            while (numeroDiferenteUm(n))
            {
                if ((n & 1) == 0)
                {
                    n = CalculoPar(n);
                }
                else
                {
                    n = CalculoImpar(n);
                }
                tamanho += 1;
            }
            return new TamanhoCollatz()
            {
                Valor = valor,
                Tamanho = tamanho,
            };
        }
        /// <summary>
        /// Método responsável por comparar tamanhos de sequencias.
        /// </summary>
        /// <param name="outro"></param>
        /// <returns></returns>
        public int CompareTo(TamanhoCollatz outro)
        {
            return Tamanho.CompareTo(outro.Tamanho);
        }

        /// <summary>
        /// Método booleano para usar no if.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private bool numeroDiferenteUm(long numero)
        {
            if (numero != 1)
                return true;
            return false;
        }


        /// <summary>
        ///  ToString() sobreescrito para exibir o valor e tamanho.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(" Valor obtido como maior possível de 1 a 1milhao: {0},\n Tamanho da sequência: {1}", Valor, Tamanho);
        }


        long CalculoImpar(long n)
        {
            return (3 * n) + 1;
        }

        long CalculoPar(long n)
        {
            return n /= 2;
        }
    }

}