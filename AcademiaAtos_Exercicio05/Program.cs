namespace AcademiaAtos_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros.
            // Encontre e mostre o menor elemento e a sua posição.

            int[] vetor = new int[80];

            // Preenche o vetor com valores inteiros
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o elemento {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            // Encontra o menor elemento e sua posição
            int menor = vetor[0];
            int posicao = 0;
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao = i;
                }
            }

            // Mostra o menor elemento e sua posição
            Console.WriteLine("O menor elemento é {0} e está na posição {1}", menor, posicao);
        }
    }
}