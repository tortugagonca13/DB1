using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaNaoContem
{

    public class ListExtractor
    {
        Impressor impressor = new Impressor();

        /// <summary>
        /// Verifica a lista antes de extraí-la
        /// </summary>
        /// <param name="primeiraLista"></param>
        /// <param name="segundaLista"></param>
        /// <returns></returns>
        public List<int> VerificadorListas(List<int> primeiraLista, List<int> segundaLista)
        {
            // teste // primeiraLista = null;
            if (!ListaVazia(primeiraLista, segundaLista))
                impressor.MensagemErro("Há listas vazias que não podem ser utilizadas");
            return ExtraiValores(primeiraLista, segundaLista);

        }

        /// <summary>
        /// Método que verifica se alguma lista está vazia.
        /// </summary>
        /// <param name="primeiraLista"></param>
        /// <param name="segundaLista"></param>
        /// <returns></returns>
        private bool ListaVazia(List<int> primeiraLista, List<int> segundaLista)
        {
            if (primeiraLista == null || segundaLista == null)
                return false;
            return true;
        }

        /// <summary>
        /// Extrai valores que estão na primeira lista que não estão na segunda
        /// </summary>
        /// <param name="primeiraLista"></param>
        /// <param name="segundaLista"></param>
        /// <returns></returns>
        private static List<int> ExtraiValores(List<int> primeiraLista, List<int> segundaLista)
        {
            return primeiraLista
                .Except(segundaLista)
                .ToList();
        }

    }
}