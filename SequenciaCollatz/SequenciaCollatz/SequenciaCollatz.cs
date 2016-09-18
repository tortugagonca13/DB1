using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            TamanhoCollatz tamanhoCollatz = new TamanhoCollatz();

            var range= Enumerable.Range(1, 1000000);
            var paralelo = range.AsParallel();
            var onde = paralelo.Where(n => (n & 1) != 0);
            var selecione = onde.Select(n => tamanhoCollatz.Encontre(n));
            var maximo = selecione.Max();

            Console.Write(maximo);
            Console.Write("\n Precione <enter> para fechar");
            Console.Read();
        }
    }
}