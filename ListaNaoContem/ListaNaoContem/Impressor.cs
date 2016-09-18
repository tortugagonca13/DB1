using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaNaoContem
{
    public class Impressor
    {
        public void ImprimeLista(List<int> lista, string msg)
        {
            Console.Write(msg);
            foreach (int numero in lista)
            {
                ImpressorGenerico(numero);
            }
            Console.Write(";");
            Console.WriteLine();
        }
        private static void ImpressorGenerico(int numero)
        {
            Console.Write(" [" + numero + "]");
        }

        public void MensagemErro(string mensagem)
        {
            Console.Write(mensagem);
        }

       
    }
}
