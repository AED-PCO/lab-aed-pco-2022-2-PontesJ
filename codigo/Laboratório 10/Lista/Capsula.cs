using System;

namespace Lista
{
    class Capsula
    {
        public int numero;
        public Capsula apontador;

        public Capsula() { }
        public Capsula(int numero)
        {
            this.numero = numero;
            apontador = null;
        }
    }
}
