using System;

namespace Quick_Sort
{
    class Program
    {
        static void criaVetor(int []vetor) {
            for (int i = 0; i < vetor.Length; i++) {
                Random rand = new Random();
                vetor[i] = rand.Next(0,10);
            }
        }
        static void quickSort (int []vetor) {
            
        }
        static void Main(string[] args)
        {
            const int tam = 10;
            int []vetor = new int[tam];
            criaVetor(vetor);
            Console.WriteLine("\n================================");
            Console.WriteLine("Quick Sort");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrdenado: ");
            quickSort(vetor);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}