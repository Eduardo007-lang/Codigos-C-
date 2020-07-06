using System;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            int notasde100 = (valor / 100);
            int notasde50 = (valor % 100) / 50;
            int notasde20 = ((valor % 100) % 50) / 20;
            int notasde10 = (((valor % 100) % 50) % 20) / 10;
            int notasde5 = ((((valor % 100) % 50) % 20) % 10) / 5;
            int notasde2 = (((((valor % 100) % 50) % 20) % 10) % 5) / 2;
            int notasde1 = ((((((valor % 100) % 50) % 20) % 10) % 5) % 2) / 1;

            Console.WriteLine(notasde100 + " notas de R$ 100,00");
            Console.WriteLine(notasde50 + " notas de R$ 50,00");
            Console.WriteLine(notasde20 + " notas de R$ 20,00");
            Console.WriteLine(notasde10 + " notas de R$ 10,00");
            Console.WriteLine(notasde5 + " notas de R$ 5,00");
            Console.WriteLine(notasde2 + " notas de R$ 2,00");
            Console.WriteLine(notasde1 + " notas de R$ 1,00");

        }
    }
}
