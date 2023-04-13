using System;
using System.Runtime.Intrinsics.X86;

namespace AcademiaAtos_Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
            // •	A união de X com Y
            // •	A diferença entre X e Y
            // •	A interseção entre X e Y
            // Escreva o vetor resultado de cada uma das operações.

            // Declaração dos vetores X e Y
            int[] X = new int[10];
            int[] Y = new int[10];
            int[] diferenca = new int[10];
            int[] uniao = new int[20];

            // Leitura dos valores do vetor X
            Console.WriteLine("Digite os valores do vetor X: ");
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write("X [" + i + "]: ");
                X[i] = int.Parse(Console.ReadLine());
            }

            // Leitura dos valores do vetor Y
            Console.WriteLine("Digite os valores do vetor Y: ");
            for (int i = 0; i < Y.Length; i++)
            {
                Console.Write("Y [" + i + "]: ");
                Y[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // União de X com Y
            uniao = X.Concat(Y).ToArray();
            Console.WriteLine("União: " + string.Join("  ", uniao));

            // Diferença entre X e Y
            Console.Write("Diferença: ");
            for (int i = 0; i < X.Length; i++)
            {
                diferenca[i] = X[i] - Y[i];
                Console.Write(diferenca[i] + "  ");
            }
            
            // Interseção entre X e Y
            Console.Write("\nInterseção: ");
            
            var intersecao = X.Intersect(Y);

            foreach (var valor in intersecao)
            {
                Console.Write(valor + "  ");
            }
            Console.WriteLine();
        }
    }
}