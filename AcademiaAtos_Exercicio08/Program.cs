namespace AcademiaAtos_Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva
            // a posição de cada número menor que zero desse vetor. Exemplo:
            // a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
            // b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .

            double[] numeros = new double[5]; // devlaração de vetor
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = double.Parse(Console.ReadLine()); // recebe o valor do usuario digitado
            }

            Console.Write("Posições dos números negativos: ");
            for (int i = 0; i < numeros.Length; i++) // percorre o vetor
            {
                if (numeros[i] < 0)
                {
                    Console.Write($"{i} "); // escreve na tela os numeros positivos.
                }
            }
            Console.Write(", (posição do vetor)");
        }
    }
}