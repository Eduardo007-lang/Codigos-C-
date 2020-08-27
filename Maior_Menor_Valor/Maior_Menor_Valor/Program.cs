using System;

namespace Maior_Menor_Valor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {

                Console.WriteLine("O primeiro numero é maior!");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("O segundo numero é maior");

            }
            else {
                Console.WriteLine("Não existe valor maior, os dois são iguais!");
            }
        }
    }
}
