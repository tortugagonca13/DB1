using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaNaoContem
{
    class Program
    {
        static void Main(string[] args)
        {
            Impressor impressor = new Impressor();
            ListExtractor extraiListas = new ListExtractor();

            List<int> primeiraLista = InicializarListaUm();
            List<int> segundaLista = InicializarListaDois();
            List<int> primeiraExceptSegunda = extraiListas.VerificadorListas(primeiraLista, segundaLista);

            impressor.ImprimeLista(primeiraLista, "Primeira Lista: ");
            impressor.ImprimeLista(segundaLista, "Segunda Lista: ");
            impressor.ImprimeLista(primeiraExceptSegunda, "Elementos extraídos: ");
            Console.Read();
        }

        private static List<int> InicializarListaUm()
        {
            return new List<int> { 1, 3, 7, 29, 42, 98, 234, 93 };
        }
        private static List<int> InicializarListaDois()
        {
            return new List<int> { 4, 6, 93, 7, 55, 32, 3 };
        }
    }
}
