namespace AcademiaAtos_Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números.
            // Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido.
            // Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

            int codigo, i;
            int[] vetor = new int[10]; // Declaração do vetor com 50 posições

            for (i = 0; i < vetor.Length; i++)
            { // Loop para o usuário digitar os números do vetor
                Console.Write($"Digite o {i + 1}º número do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Digite o código 0 para sair!");
                Console.WriteLine("Digite o código 1 para mostrar o vetor na ordem em que foi lido e sair!");
                Console.WriteLine("Digite o código 2 para mostrar o vetor na ordem inversa e sair!"); 
                codigo = int.Parse(Console.ReadLine()); // Leitura do código digitado pelo usuário

                switch (codigo)
                { // Verificação do código digitado
                    case 0: // Se o código for 0, finaliza o programa
                        Console.WriteLine("Fim do programa.");
                        break;
                    case 1: // Se o código for 1, mostra o vetor na ordem em que foi lido
                        Console.WriteLine("Vetor na ordem em que foi lido:");
                        for (i = 0; i < vetor.Length; i++)
                        { // Percorre o vetor de 0 a 49
                            Console.WriteLine(vetor[i]); // Mostra o elemento do vetor na posição atual
                        }
                        break;
                    case 2: // Se o código for 2, mostra o vetor na ordem inversa
                        Console.WriteLine("Vetor na ordem inversa:");
                        for (i = 9; i >= 0; i--)
                        { // Percorre o vetor de 49 a 0
                            Console.WriteLine(vetor[i]); // Mostra o elemento do vetor na posição atual
                        }
                        break;
                    default: // Se o código for diferente de 0, 1 ou 2, indica que o código é inválido
                        Console.WriteLine("Código inválido.");
                        break;
                }
            } while (codigo != 0); // Continua o laço enquanto o código for diferente de 0


        }
    }
}