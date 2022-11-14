using System;

namespace Pilha
{
    class Capsula
    {
        public int numero;
        public Capsula apontador;
        public Capsula(int numero)
        {
            this.numero = numero;
            apontador = null;
        }
    }
}
