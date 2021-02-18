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

            media = ( n1 * 2 ) + ( n2 * 3 )+ ( n3 * 5) / 10.0;

        Console.WriteLine("MEDIA = " + media);

        }
    }
}
