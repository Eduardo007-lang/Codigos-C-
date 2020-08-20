using System;
using System.Globalization;

namespace Atividade_7_Condicao
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.Write("PROMOÇÃO DIA DAS MULHERES!!!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            Console.Write("Qual é o seu sexo?(M/F)? ");
            char sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.Write("Valor da Compra: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("------------------------------------");

          
            double desconto = 0;
            if (sexo == 'F'|| sexo == 'f')
            {
                desconto = valor * 15 / 100;
                double total = valor - desconto;
                Console.WriteLine($"De: {valor.ToString("F2", CultureInfo.InvariantCulture)} sai para {total.ToString("F2",CultureInfo.InvariantCulture)}, com o desconto de 15% mulher");
               

            }
            else if (sexo == 'M'|| sexo == 'm') {

                desconto = (valor * 5 / 100);
                double total = valor - desconto;
                Console.WriteLine($"De: {valor.ToString("F2", CultureInfo.InvariantCulture)} sai para {total.ToString("F2", CultureInfo.InvariantCulture)}, com o desconto de 5% homem");
            }
            else
            {

                Console.ReadKey();

            }

            
        }
    }
}
