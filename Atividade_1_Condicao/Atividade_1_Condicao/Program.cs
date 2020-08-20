using System;
using System.Globalization;

namespace Atividade_1_Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a velocidade do carro: ");
            double velo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double veloc = 0;
            double multa = 0;
            if (velo > 80.0)
            {
                Console.WriteLine("Voce foi multado!");
                veloc = velo - 80;
                multa = veloc * 5.0;
                Console.WriteLine($"Valor da multa por km/h:{multa.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else {

                Console.ReadKey();
            }
          
        }
    }
}
