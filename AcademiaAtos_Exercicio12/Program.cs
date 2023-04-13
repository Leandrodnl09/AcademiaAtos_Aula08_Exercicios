namespace AcademiaAtos_Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N,
            // fornecido pelo usuário, existe no vetor.Se existir, indicar a(s) posição(ões),
            // se não escrever a mensagem "O número fornecido não existe no vetor!".

            int[] v = new int[10];
            int n, i;
            bool encontrado = false;

            // ler os valores do vetor
            for (i = 0; i < v.Length; i++)
            {
                Console.Write("Digite o valor para a posição {0}: ", i + 1);
                v[i] = int.Parse(Console.ReadLine());
            }

            // ler o número a ser buscado
            Console.Write("Digite o número a ser buscado: ");
            n = int.Parse(Console.ReadLine());

            // buscar o número no vetor
            for (i = 0; i < v.Length; i++)
            {
                if (v[i] == n)
                {
                    Console.WriteLine("O número {0} foi encontrado na posição {1} (posição de vetor).", n, i + 1);
                    encontrado = true;
                }
            }

            // verificar se o número foi encontrado
            if (!encontrado)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }
        }
    }
}