using System;
using System.Globalization;

namespace Consumo_De_Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());


            double consumo = tempo * velocidade / 12;

            Console.WriteLine(consumo.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
