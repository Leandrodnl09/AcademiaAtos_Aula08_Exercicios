namespace AcademiaAtos_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice,
            // colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

            // Declaração dos vetores
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetorResultado = new int[10];

            // Leitura do primeiro vetor
            Console.WriteLine("Digite os valores do primeiro vetor:");
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Vetor1[{0}]: ", i + 1);
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            // Leitura do segundo vetor
            Console.WriteLine("Digite os valores do segundo vetor:");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("Vetor2[{0}]: ", i + 1);
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            // Multiplicação dos elementos de mesmo índice e armazenamento no vetor resultado
            for (int i = 0; i < vetorResultado.Length; i++)
            {
                vetorResultado[i] = vetor1[i] * vetor2[i];
            }

            // Exibição do vetor resultado
            Console.WriteLine("O vetor resultante é:");
            for (int i = 0; i < vetorResultado.Length; i++)
            {
                Console.WriteLine("VetorResultado[{0}]: {1}", i + 1, vetorResultado[i]);
            }
        }
    }
}