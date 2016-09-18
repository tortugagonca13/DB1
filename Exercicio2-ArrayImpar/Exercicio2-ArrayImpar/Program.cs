using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE2ArrayImpar
{
    class Program
    {
        /// <summary>
        /// Principal - Chama os métodos para realizar as suas devidas funções
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> numeros = SetValorOriginalLista();
            Impressor impressor = new Impressor();
            OddExtractor oddExtractor = new OddExtractor();
            List<int> numerosImpares = oddExtractor.ExtraiImpar(numeros);
            impressor.ImprimeSequencias(numeros, numerosImpares);
            Console.Read();
        }

        /// <summary>
        /// Instancia uma Lista do tipo Int com os valores pré definidos no exercício
        /// </summary>
        /// <returns></returns>
        private static List<int> SetValorOriginalLista()
        {
            return new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
        }

        /// <summary>
        /// Imprime sequências chamando respectivos métodos
        /// </summary>
        /// <param name="numeros"></param>
        /// <param name="numerosImpares"></param>
        private static void ImprimeSequencias(List<int> numeros, List<int> numerosImpares)
        {
            ImprimeSequenciaOriginal(numeros);
            Console.WriteLine();
            ImprimeSequenciaImpar(numerosImpares);
        }
        
        /// <summary>
        /// Imprime a Sequência Original
        /// </summary>
        /// <param name="numeros"></param>
        private static void ImprimeSequenciaOriginal(List<int> numeros)
        {
            Console.Write("Sequência original:");
            foreach (int numero in numeros)
            {
                ImpressorGenericoNumero(numero);
            }
            Console.Write(";");
        }

        /// <summary>
        /// Imprime a Sequencia Impar
        /// </summary>
        /// <param name="numerosImpares"></param>
        private static void ImprimeSequenciaImpar(List<int> numerosImpares)
        {
            Console.Write("Sequência ímpar:");
            foreach (int numero in numerosImpares)
            {
                ImpressorGenericoNumero(numero);
            }
            Console.Write(";");
        }

        /// <summary>
        /// Impressor genérico usado nas classes de impressão
        /// </summary>
        /// <param name="numero"></param>
        private static void ImpressorGenericoNumero(int numero)
        {
            Console.Write(" [" + numero + "]");
        }
    }
}
