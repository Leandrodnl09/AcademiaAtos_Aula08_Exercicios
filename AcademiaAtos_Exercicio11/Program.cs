namespace AcademiaAtos_Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11.	Escreva um programa que leia valores em um vetor de 5 posições.
            // Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

            int[] vetor = new int[5];

            // leitura dos valores do vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um valor para a posição {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            // escrita dos elementos do vetor
            Console.WriteLine("\nElementos do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            // escrita dos elementos do vetor em ordem inversa
            Console.WriteLine("\nElementos do vetor em ordem inversa:");
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}