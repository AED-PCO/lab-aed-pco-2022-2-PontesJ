using System;

namespace Pilha
{
    class Capsula
    {
        public string numero;
        public Capsula apontador;
        public Capsula(string numero)
        {
            this.numero = numero;
            apontador = null;
        }
    }
}
