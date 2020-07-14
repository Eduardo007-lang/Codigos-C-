using System;

namespace Moedas_e__Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int valor = 0;

            Console.WriteLine("NOTAS: ");
            valor = (int)N / 100;
            Console.WriteLine("{0} nota(s) de R$ 100.00", valor);
            N = N % 100;

            valor = (int)N / 50;
            Console.WriteLine("{0} nota(s) de R$ 50.00", valor);
            N = N % 50;

            valor = (int)N / 20;
            Console.WriteLine("{0} nota(s) de R$ 20.00", valor);
            N = N % 20;

            valor = (int)N / 10;
            Console.WriteLine("{0} nota(s) de R$ 10.00", valor);
            N = N % 10;

            valor = (int)N / 5;
            Console.WriteLine("{0} nota(s) de R$ 5.00", valor);
            N = N % 5;

            valor = (int)N / 2;
            Console.WriteLine("{0} nota(s) de R$ 2.00", valor);
            N = N % 2;
            Console.WriteLine();

            Console.WriteLine("MOEDAS: ");

            valor = (int)N / 100;
            Console.WriteLine("{0} moeda(s) de R$ 1.00", valor);
            N = N % 100.0;

            valor = (int)N / 50;
            Console.WriteLine("{0} moeda(s) de R$ 00.50", valor);
            N = N % 50.0;

            valor = (int)N / 25;
            Console.WriteLine("{0} moeda(s) de R$ 00.25", valor);
            N = N % 25.0;

            valor = (int)N / 10;
            Console.WriteLine("{0} moeda(s) de R$ 00.10", valor);
            N = N % 10.0;

            valor = (int)N / 5;
            Console.WriteLine("{0} moeda(s) de R$ 00.05", valor);
            N = N % 5.0;


            valor = (int)N / 1;
            Console.WriteLine("{0} moeda(s) de R$ 00.01", valor);
            N = N % 1.0;
        }
    }
}
