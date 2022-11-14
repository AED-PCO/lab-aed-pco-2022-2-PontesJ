using System;

namespace Fila
{
    class Filas
    {
        private Capsula primeiro, ultimo;
        public Filas()
        {
            primeiro = new Capsula();
            ultimo = primeiro;
        }
        public void adicionar(int num)
        {
            ultimo.apontador = new Capsula(num);
            ultimo = ultimo.apontador;
        }
        public int remover()
        {
            if (primeiro == ultimo)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Fila Vazia");
                Console.ResetColor();
                return -1;
            }
            Capsula aux = primeiro;
            primeiro = primeiro.apontador;
            int sair = primeiro.numero;
            aux.apontador = null;
            aux = null;
            return sair;
        }
        public void imprimi()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A fila: ");

            for (Capsula i = primeiro.apontador; i != null; i = i.apontador)
                Console.Write("{0} ", i.numero);

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}