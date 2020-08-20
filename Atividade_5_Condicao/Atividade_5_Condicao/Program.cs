using System;

namespace Atividade_5_Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma data: ");
            int data = int.Parse(Console.ReadLine());

            if (data % 4 == 0)
            {

                Console.WriteLine($"Ano de {data} é Bissexto!");
            }
            else {

                Console.WriteLine($"Ano de {data} não é bissexto!");
            }

            Console.ReadKey();
        }
    }
}
