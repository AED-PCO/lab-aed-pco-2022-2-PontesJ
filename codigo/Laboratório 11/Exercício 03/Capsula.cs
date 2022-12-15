namespace Exercício_03
{
    class Capsula
    {
        public string valor;
        public Capsula frente, tras;
        public Capsula()
        {
            valor = "";
            frente = null;
            tras = null;
        }
        public Capsula(string valor)
        {
            this.valor = valor;
            frente = null;
            tras = null;
        }
    }
}
