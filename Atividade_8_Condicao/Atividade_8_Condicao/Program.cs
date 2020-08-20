using System;
using System.Globalization;

namespace Atividade_8_Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Km deseja pecorrer ? ");
            int  Km = int.Parse(Console.ReadLine());


            if (Km <= 200)
            {
                double Valor = (double)Km * 0.50;

                Console.WriteLine($"Valor da passagem: {Valor.ToString("F2", CultureInfo.InvariantCulture)}$");
            }
            else if (Km > 200) {

                double Valor = (double)Km * 0.45;

                Console.WriteLine($"Valor da passagem: {Valor.ToString("F2", CultureInfo.InvariantCulture)}$");
            }
        }
    }
}
