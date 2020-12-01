using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta_Bancaria conta;

            Console.Write("Entre o número da conta: ");
            int cont = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {

                Console.Write("Entre com o valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta_Bancaria(cont, titular, depositoInicial);

            }
            else {

                conta = new Conta_Bancaria(cont, titular);
            }





        }
    }
}
