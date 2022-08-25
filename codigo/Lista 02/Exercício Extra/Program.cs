using System;

namespace Exercício_Extra
{
    class Program
    {
        static int fibonacci(int x)
        {
            if (x == 0) return 0;
            else if (x == 1) return 1;
            return fibonacci(x - 1) + fibonacci(x - 2);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício Extra");
            Console.Write("\nDigite o número da posição que deseja encontrar na sequência de fibonacci: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nA posição {0}° corresponde ao número {1} na sequência de fibonacci", n, fibonacci(n));
            Console.WriteLine("\n================================");
        }
    }
}
