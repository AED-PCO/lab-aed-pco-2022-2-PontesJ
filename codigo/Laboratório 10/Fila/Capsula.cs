using System;

namespace Fila
{
    class Capsula
    {
        public string numero;
        public Capsula apontador;

        public Capsula() { }
        public Capsula(string numero)
        {
            this.numero = numero;
            apontador = null;
        }
    }
}
