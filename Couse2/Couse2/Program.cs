using System;
using System.Globalization;
using System.Transactions;

namespace Couse2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many rooms will be rented: ");
            int n = int.Parse(Console.ReadLine());

            Rent[] vet = new Rent[10];

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine("Rent #{0}: ", i);
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Bedroom: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Rent(nome, email);

            }

            Console.WriteLine();
            Console.WriteLine("Occupied rooms: ");
            for (int i = 0; i < 10; i++) 
            { 
             if(vet[i] != null)
                    Console.WriteLine(i + ": " + vet[i]);


            }


      






        }
    }
}
