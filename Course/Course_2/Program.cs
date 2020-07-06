using System;
using System.Globalization;


namespace Course_2
{
    class Program
    {
        static void Main(string[] args)

        {
            ContaBancaria cont;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {

                Console.Write("Entre o valor de depósito inicial: ");

                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                cont = new ContaBancaria(numero, titular, depositoInicial);

            }

            else
            {

                cont = new ContaBancaria(numero, titular);

            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cont);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cont.deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cont);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cont.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cont);




        }
    }
}



 


    

