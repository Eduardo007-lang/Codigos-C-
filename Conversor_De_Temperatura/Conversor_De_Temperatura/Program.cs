using System;
using System.Globalization;

namespace Conversor_De_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a temperatura em F? ");
            double F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double C = (F - 32) / 1.8;

            Console.WriteLine($"A temperatura em C ou Celsius será:{C.ToString("F1", CultureInfo.InvariantCulture)} ");

            Console.ReadKey();

        }
    }
}
