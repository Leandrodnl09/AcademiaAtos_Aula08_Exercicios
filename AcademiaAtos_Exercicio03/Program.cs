namespace AcademiaAtos_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos
            // e então mostre na tela o índice da posição dos valores correspondentes a números primos.


            int[] vetor = new int[20]; // Cria um vetor de 20 elementos

            for (int i = 0; i < vetor.Length; i++)
            { // Loop para ler os valores do usuário e armazenar no vetor
                Console.Write("Digite o valor do elemento " + (i + 1) + ": ");
                vetor[i] = int.Parse(Console.ReadLine()); // Armazena o valor lido na posição i do vetor
            }

            Console.Write("Os números primos estão nas posições: ");
            for (int i = 0; i < vetor.Length; i++)
            { // Loop para verificar quais elementos do vetor são números primos
                bool isPrime = true; // Define a variável isPrime como true, que significa que o número é primo até que se prove o contrário
                if (vetor[i] <= 1)
                { // Se o número for menor ou igual a 1, ele não é primo
                    isPrime = false;
                }
                for (int j = 2; j <= Math.Sqrt(vetor[i]); j++)
                { // Loop para verificar se o número é divisível por algum número menor que ele
                    if (vetor[i] % j == 0)
                    {
                        isPrime = false; // Se for divisível, o número não é primo
                        break; // Se já foi identificado que o número não é primo, podemos sair do loop
                    }
                }
                if (isPrime)
                { // Se a variável isPrime permanecer true após o loop, o número é primo
                    Console.Write(i + " "); // Imprime na tela a posição do número primo no vetor
                }
            }
        }
    }
}