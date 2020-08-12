using System;
using System.Globalization;

namespace Array_Salario_5posicoes
{
    class Program
    {
        static void Main(string[] args)

            //Vetor com valores já adicionados 
        {
            /*  double[] salario = new double[] {2500.00, 1400.00, 300.00, 1200.00, 1100.00 };

              double menor = salario[0];
              for (int i = 1; i < 5; i++) 
              {
                  if (salario[i] < 1000)
                      menor = (salario[i] * 10/100) + salario[i];

              }

              Console.WriteLine($"Salario atualizado:{menor.ToString("F2", CultureInfo.InvariantCulture}");*/


            //Vetor com valores adicionado pelo usuario

            int n = int.Parse(Console.ReadLine());

            double[] salario = new double[n];

            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine($"Salario #{i}");
               salario[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

          

            double menor = salario[0];
            for (int i = 1; i < n; i++) 
            {
                if (salario[i] < 1000)
                    menor = (salario[i] * 10 / 100) + salario[i];
            
            }

            Console.WriteLine($"Menor salario atualizado:{menor.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
