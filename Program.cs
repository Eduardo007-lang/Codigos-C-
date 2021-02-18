using System;
using System.Globalization;

namespace Csharp_test
{
    class Program
    {
        static void Main(string[] args)
        {
          double n1, n2, n3, media;

          n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  

            media = (n1 * 2.0 * n2 * 3.0 * n3 * 5.0) / 10;

        Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
