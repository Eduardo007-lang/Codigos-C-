using System;
using System.Globalization;

namespace Media_Escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("COLÉGIO CORA CCORALINA ");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.Write("Primeira Nota: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segunda Nota: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("---------------------------------------------------------------");

            double Media = n1 + n2 / 2;

            if (Media >= 7.0) {
              
                Console.WriteLine($"MEDIA: {Media.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("ALUNO APROVADO.");
                Console.WriteLine("---------------------------------------------------------------");

            }
            else
            {
                
                Console.WriteLine($"MEDIA: {Media.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("ALUNO REPROVADO.");
                Console.WriteLine("---------------------------------------------------------------");

            }

        }
    }
}
