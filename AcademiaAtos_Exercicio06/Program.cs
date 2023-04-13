namespace AcademiaAtos_Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
            // a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            // b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

            int[] numeros = new int[10];

            // Lê os 10 números
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Escreve os 10 números na ordem contrária
            Console.Write("Os números na ordem contrária são: ");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write($"{numeros[i]} ");
            }
        }
    }
}