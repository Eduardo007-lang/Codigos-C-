using System;
using System.Globalization;

namespace Array_MediaAritimetica
{
    class Program
    {
        static void Main(string[] args)
        {
             
             int n = int.Parse(Console.ReadLine());

             double[] ari = new double[n];

            double soma = 0;
            for (int i = 0; i < n; i++) 
            {
                ari[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                soma = soma + ari[i] / n;

            }

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
