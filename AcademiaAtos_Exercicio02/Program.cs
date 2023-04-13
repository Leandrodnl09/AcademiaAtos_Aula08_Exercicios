namespace AcademiaAtos_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize
            // a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

            // Definir os vetores e o vetor resultado
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] resultado = new int[20];

            // Ler os valores para o primeiro vetor
            Console.WriteLine("Digite os valores para o primeiro vetor:");
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Elemento {0}: ", i + 1);
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            // Ler os valores para o segundo vetor
            Console.WriteLine("Digite os valores para o segundo vetor:");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("Elemento {0}: ", i + 1);
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            // Realizar a soma dos elementos na mesma posição
            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = vetor1[i] + vetor2[i];
            }

            // Imprimir o vetor resultado
            Console.WriteLine("Resultado da soma dos vetores:");
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine("Elemento {0}: {1}", i + 1, resultado[i]);
            }
        }
    }
}