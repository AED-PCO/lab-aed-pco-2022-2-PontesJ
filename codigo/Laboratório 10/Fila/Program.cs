using System;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Filas f = new Filas();
            f.inserir(5);
            f.inserir(2);
            Console.WriteLine(f.remover());
            f.inserir(6);
            f.imprimir();
        }
    }
}
