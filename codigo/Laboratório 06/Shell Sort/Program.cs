using System;

namespace Shell_Sort
{
    class Program
    {
        static void criaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Random rand = new Random();
                vetor[i] = rand.Next();
            }
        }
        static void shellSort(int[] vetor, ref int c, ref int t)
        {
            for (int gap = vetor.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < vetor.Length; i += 1)
                {
                    int aux = vetor[i];
                    int j;
                    c++;
                    for (j = i; j >= gap && vetor[j - gap] > aux; j -= gap){
                        t++;
                        vetor[j] = vetor[j - gap];
                    }
                    vetor[j] = aux;
                    t++;
                }
            }
        }
        static void Main(string[] args)
        {
            int c = 0, t = 0;
            const int tam = 10000;
            int[] vetor = new int[tam];
            criaVetor(vetor);
            Console.WriteLine("\n================================");
            Console.WriteLine("Shell Sort");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrdenado: ");
            shellSort(vetor, ref c, ref t);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
            Console.WriteLine("Comparação: {0}\nTroca: {1}", c, t);

        }
    }
}