using System;
using System.Globalization;

namespace Salarios_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] Salario = new double[5];

            for (int i = 1; i < 5; i++ )
            {
                Salario[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            }

            double maior = Salario[1];
            for (int i = 2; i < 5; i++) 
            {
                if (maior < Salario[i])
                    maior = Salario[i];
            
            }
            Console.WriteLine($"Maior Salario = {maior.ToString("F2", CultureInfo.InvariantCulture)} ");

            Console.ReadKey();
        }
    }
}
