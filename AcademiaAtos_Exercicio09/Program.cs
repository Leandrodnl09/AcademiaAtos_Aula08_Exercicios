namespace AcademiaAtos_Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos,
            // e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

            int[] vetor = new int[10];
            int[] auxiliar = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            // Ordena o vetor em ordem crescente
            for (int i = 0; i < vetor.Length; i++)
            {
                int menorValor = vetor[i];
                int posicaoMenorValor = i;

                for (int j = i + 1; j < 10; j++)
                {
                    if (vetor[j] < menorValor)
                    {
                        menorValor = vetor[j];
                        posicaoMenorValor = j;
                    }
                }

                auxiliar[i] = menorValor;
                vetor[posicaoMenorValor] = vetor[i];
            }

            // Exibe o vetor ordenado em ordem crescente
            Console.WriteLine("Vetor ordenado em ordem crescente:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0} ", auxiliar[i]);
            }
        }
    }
}