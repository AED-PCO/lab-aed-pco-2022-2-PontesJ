using System;

namespace Exercício_04
{
    class Program
    {
        static int procurar(int[] vetor, int inicio, int tam, int numero, ref int a, ref int c, ref int s)
        {
            c++;
            if (inicio <= tam)
            {
                a++;
                s++;
                int metade = inicio + (tam - inicio) / 2;
                c++;
                if (vetor[metade] == numero){
                    s++;
                    return metade + 1;
                }
                c++;
                if (vetor[metade] > numero) return procurar(vetor, inicio, metade - 1, numero, ref a, ref c, ref s);
                s++;
                return procurar(vetor, metade + 1, tam, numero, ref a, ref c, ref s);
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int a = 0, c = 0, s = 0;
            const int tam = 10000;
            int[] vetor = new int[tam];
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = i + 1;
            }
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 04");
            Console.Write("\nDigite o número que deseja procurar no vetor: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nO número {0} se encontra na {1}° posição", n, procurar(vetor, 0, tam - 1, n, ref a, ref c, ref s));
            Console.WriteLine("\n================================\n");
            Console.WriteLine("Atribuição: {0}\nComparação: {1}\nSoma: {2}", a, c, s);
        }
    }
}
