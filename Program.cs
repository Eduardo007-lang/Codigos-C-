using System;
using System.Globalization;

namespace C_TESTE
{
    class Program
    {
        static void Main(string[] args)
        {
         
            {


            int SO, idade, count = 0, iOS = 0, android = 0, somaIdade = 0, n;

            double mediaIdade;

            Console.Write("Quantos pessoas serao entrevistadas: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Qual sistema operacional voce utiliza? (1 - iOS || 2 - Android) ");
                SO = int.Parse(Console.ReadLine());


                while (SO != 1 && SO != 2)
                {
                    Console.Write("Digite um numero valido (1 - iOS || 2 - Android): ");
                    SO = int.Parse(Console.ReadLine());
                }
                Console.Write("Qual a sua idade? ");
                idade = int.Parse(Console.ReadLine());
                

                count++;

                if (SO == 1)
                {
                    iOS++;
                }
                else
                {
                    android++;
                }

                somaIdade += idade;
            }

            mediaIdade = (double)somaIdade / count;

            Console.WriteLine($"Quantidade de pessoas entrevistadas:{count}");
            Console.WriteLine($"Quantidade de usuario iOS:{iOS}");
            Console.WriteLine($"Quantidade de usuario Android:{android}");
            Console.WriteLine($"Idade media das pessoas entrevistadas:{mediaIdade.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

}
            
