namespace AcademiaAtos_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos
            // e então mostre na tela a quantidade de números pares e ímpares.

            int[] numero = new int[10];
            
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                numero[i] = int.Parse( Console.ReadLine() );
            }
            int numerosPares = 0;
            int numerosImpares = 0;
            for (int i = 0;i < numero.Length;i++)
            {
                if (numero[i] % 2 == 0)
                {
                    numerosPares++;
                }
                else
                {
                    numerosImpares++;
                }
            }

            Console.WriteLine("A quantidade de numeros pares são: " + numerosPares);
            Console.WriteLine("A quantidade de numeros impares são: " + numerosImpares);
        }
    }
}