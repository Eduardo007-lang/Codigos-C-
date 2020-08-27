using System;
using System.Globalization;

namespace Criança_Esperança
{
    class Program
    {
        static void Main(string[] args)
        {
            int D;
            double valor=0;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("CRIANÇA ESPERANÇA!!!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Muito obrigado por ajudar!");
            Console.WriteLine("[1] para doar R$10");
            Console.WriteLine("[2] para doar R$25");
            Console.WriteLine("[3] para doar R$50");
            Console.WriteLine("[4] para doar outros valores:");
            Console.WriteLine("[5] para cancelar");
            D = int.Parse(Console.ReadLine());
            switch (D) {
                case 1:
                    valor = 10;
                    break;
                case 2:
                    valor = 25;
                    break;
                case 3:
                    valor = 50;
                    break;
                case 4:
                    Console.Write("Qual é valor da sua doação? ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    break;
                case 5:
                    valor = 0;
                    break;
                        
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Sua doação foi de R${valor.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("-----------------------------------");


        }
    }
}
