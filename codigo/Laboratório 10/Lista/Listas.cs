using System;

namespace Lista
{
    class Listas
    {
        private Capsula primeiro, ultimo;
        public Listas()
        {
            primeiro = new Capsula();
            ultimo = primeiro;
        }
        public int tam()
        {
            int aux = 0;
            for (Capsula i = primeiro; i != ultimo; i = i.apontador)
            {
                aux++;
            }
            return aux;
        }
        public void adicionar(int num)
        {
            ultimo.apontador = new Capsula(num);
            ultimo = ultimo.apontador;
        }
        public void adicionar(int num, int pos)
        {
            pos--;
            if (pos < 0 || pos > tam())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Valor Invalido");
                Console.ResetColor();
            }
            else
            {
                Capsula aux = primeiro;
                for (int i = 0; i < pos; i++)
                {
                    aux = aux.apontador;
                }
                Capsula aux2 = new Capsula(num);
                aux2.apontador = aux.apontador;
                aux.apontador = aux2;
                aux2 = aux = null;
            }
        }
        public int remover()
        {
            if (primeiro == ultimo)
                return -1;
            else
                return 0;
        }
        public int remover(int num)
        {
            int pos = busca(num);
            if (pos < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Posição Invalida");
                Console.ResetColor();
                return -1;
            }
            else
            {
                Capsula aux = primeiro;
                for (int i = 0; i < pos; i++)
                {
                    aux = aux.apontador;
                }
                Capsula aux2 = aux.apontador;
                int sair = aux2.numero;
                aux.apontador = aux2.apontador;
                aux2.apontador = null;
                aux = aux2 = null;
                return sair;
            }  
        }
        private int busca(int num)
        {
            int aux = 0;
            for (Capsula i = primeiro.apontador; i != null; i = i.apontador)
            {
                if (num == i.numero)
                {
                    return aux;
                }
                aux++;
            }
            return -1;
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