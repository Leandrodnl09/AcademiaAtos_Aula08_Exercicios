using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace AcademiaAtos_Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15.Faça um programa em C# que declare um vetor de 20 elementos inteiros,
            // leia os conteúdos do vetor, e copie estes conteúdos para outro vetor,
            // invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor
            // deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos
            // do primeiro vetor em uma linha e os do segundo uma linha abaixo.

            // declaração dos vetores
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];

            // leitura dos elementos do vetor1
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento do vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            // cópia dos elementos do vetor1 para o vetor2, invertendo a ordem
            for (int i = 0, j = 19; i < vetor1.Length; i++, j--)
            {
                vetor2[j] = vetor1[i];
            }

            // impressão dos vetores na tela
            Console.WriteLine("\nElementos do primeiro vetor:");
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write($"{vetor1[i]}  ");
            }

            Console.WriteLine("\n\nElementos do segundo vetor (invertido):");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write($"{vetor2[i]}  ");
            }
            Console.WriteLine();
        }
    }
}