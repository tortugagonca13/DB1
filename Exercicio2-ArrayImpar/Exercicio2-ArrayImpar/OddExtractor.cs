using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE2ArrayImpar
{
    public class OddExtractor
    {

        /// <summary>
        /// Extraí os numeros impares de uma lista
        /// </summary>
        /// <param name="numeros"></param>
        /// <returns></returns>
        public List<int> ExtraiImpar(List<int> numeros)
        {
            return numeros
                  .Where(x => NumeroImpar(x))
                  .ToList();
        }

        private static bool NumeroImpar(int x)
        {
            return x % 2 == 1;
        }
    }
}
