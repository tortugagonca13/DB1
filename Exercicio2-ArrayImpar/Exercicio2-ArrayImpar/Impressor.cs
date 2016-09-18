using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXE2ArrayImpar;

namespace EXE2ArrayImpar
{
   public class Impressor
    {
        /// <summary>
        /// Imprime sequências chamando respectivos métodos
        /// </summary>
        /// <param name="numeros"></param>
        /// <param name="numerosImpares"></param>
        public void ImprimeSequencias(List<int> numeros, List<int> numerosImpares)
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
