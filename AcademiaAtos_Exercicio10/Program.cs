namespace AcademiaAtos_Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições.
            // Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

            int[] vetor = new int[20];
            int[] vetorResultante = new int[20];

            //Lendo os valores do vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor do elemento {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            //Substituindo os valores nulos por 2
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 0)
                {
                    vetorResultante[i] = 2;
                }
                else
                {
                    vetorResultante[i] = vetor[i];
                }
            }

            //Exibindo os vetores
            Console.WriteLine("Vetor Lido:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0} ", vetor[i]);
            }

            Console.WriteLine("\n\nVetor Resultante:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0} ", vetorResultante[i]);
            }
        }
    }
}