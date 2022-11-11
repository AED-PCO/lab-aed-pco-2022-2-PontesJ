using System;

namespace Fila
{
    class Celula
    {
        public int elemento;
        public Celula prox;
        
        public Celula() {}
        public Celula(int elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
    }
}
