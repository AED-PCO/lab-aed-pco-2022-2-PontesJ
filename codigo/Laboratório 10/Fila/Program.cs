using System;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Filas fila = new Filas();
            int valid;
            do
            {
                Console.Write("Inserir [1] / Remover [2] / Sair [3]: ");
                valid = int.Parse(Console.ReadLine());
                if (valid == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Digite o número: ");
                    Console.ResetColor();
                    fila.adicionar(int.Parse(Console.ReadLine()));
                    fila.imprimi();
                }
                else if (valid == 2)
                {
                    int n = fila.remover();
                    if (n != -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O número {0} foi removido", n);
                        Console.ResetColor();
                        fila.imprimi();
                    }
                }
                else if (valid != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Digite um valor valido!");
                    Console.ResetColor();
                }
            } while (valid != 3);

            fila.imprimi();
        }
    }
}
