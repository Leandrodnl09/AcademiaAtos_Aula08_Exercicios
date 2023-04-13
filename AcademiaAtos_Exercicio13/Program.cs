namespace AcademiaAtos_Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2,
            // 4 e 8. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1
            // ou quando atingir o máximo de posições do vetor.

            // Cria um vetor de inteiros com tamanho máximo de 100 posições
            int[] vetor = new int[100];
            // Variável que controla a posição atual no vetor
            int posicao = 0;
            // Variáveis que contam a quantidade de vezes que os números 2, 4 e 8 aparecem
            int dois = 0, quatro = 0, oito = 0;
            // Mensagem de entrada para o usuário
            Console.WriteLine("Digite os números inteiros e positivos (digite -1 para encerrar a entrada):");
            // Loop para ler os números digitados pelo usuário
            while (posicao < vetor.Length)
            {
                // Lê o número digitado pelo usuário
                int numero = int.Parse(Console.ReadLine());
                // Verifica se o usuário digitou -1 para encerrar a entrada
                if (numero == -1)
                {
                    break;
                }
                // Armazena o número digitado no vetor
                vetor[posicao] = numero;
                // Incrementa a posição atual no vetor
                posicao++;
            }
            // Loop para contar a quantidade de vezes que cada número aparece no vetor
            for (int i = 0; i < posicao; i++)
            {
                if (vetor[i] == 2)
                {
                    dois++;
                }
                else if (vetor[i] == 4)
                {
                    quatro++;
                }
                else if (vetor[i] == 8)
                {
                    oito++;
                }
            }
            // Imprime a quantidade de vezes que cada número apareceu no vetor
            Console.WriteLine("O número 2 apareceu " + dois + " vezes.");
            Console.WriteLine("O número 4 apareceu " + quatro + " vezes.");
            Console.WriteLine("O número 8 apareceu " + oito + " vezes.");

        }
    }
}