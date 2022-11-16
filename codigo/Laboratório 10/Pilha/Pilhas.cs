using System;

namespace Pilha
{
    class Pilhas
    {
        private Capsula primeiro;
        public Pilhas()
        {
            primeiro = null;
        }
        public void adicionar(string num)
        {
            Capsula aux = new Capsula(num);
            aux.apontador = primeiro;
            primeiro = aux;
            aux = null;
        }
        public string remover()
        {
            if (primeiro == null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pilha Vazia");
                Console.ResetColor();
                return "";
            }
            string sair = primeiro.numero;
            Capsula aux = primeiro;
            primeiro = primeiro.apontador;
            aux.apontador = null;
            aux = null;
            return sair;
        }
        public void imprimi()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A pilha: ");
            imprimi(primeiro);
            Console.WriteLine();
            Console.ResetColor();
        }
        private void imprimi(Capsula primeiro)
        {
            if (primeiro != null)
            {
                imprimi(primeiro.apontador);
                Console.Write("{0} ", primeiro.numero);
            }
        }
    }
}