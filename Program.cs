using System;
using System.Globalization;

namespace Csharp_test
{
    class Program
    {
        static void Main(string[] args)
        {
           int A, B, C, D, DIFERENCA;

           A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

           DIFERENCA = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
