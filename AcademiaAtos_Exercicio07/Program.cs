namespace AcademiaAtos_Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos
            // os números pares lidos e após todos os ímpares. Exemplo:
            // a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            // b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

            int[] numeros = new int[10];
            Console.WriteLine("Digite 10 números inteiros:");

            // Lê os números digitados pelo usuário
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números pares:");
            // Imprime os números pares
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }

            Console.WriteLine("\nNúmeros ímpares:");
            // Imprime os números ímpares
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }
        }
    }
}