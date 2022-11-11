using System;

namespace Fila
{
    class Filas
    {
        private Celula primeiro, ultimo;
        public Filas()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }
        public void inserir(int x)
        {
            ultimo.prox = new Celula(x);
            ultimo = ultimo.prox;
        }
        public int remover()
        {
            if (primeiro == ultimo)
            {
                Console.WriteLine("Fila Vazia");
                return -1;
            }
            Celula aux = primeiro;
            primeiro = primeiro.prox;
            int resp = primeiro.elemento;
            aux.prox = null;
            aux = null;
            return resp;
        }
        public void imprimir()
        {
            for(Celula i = primeiro.prox; i!= null; i = i.prox)
                Console.Write("{0} ", i.elemento);
        }
    }
}