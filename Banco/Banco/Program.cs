using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //membro de instancia
            Conta_Bancaria conta;

            //Printando mensagem na tela do usuário
            Console.Write("Entre o número da conta: ");
            //variavel do tipo inteiro
            int numero_conta = int.Parse(Console.ReadLine());
            //Printando mensagem na tela do usuário
            Console.Write("Entre o titular da conta: ");
            //variavel do tipo string 
            string titular = Console.ReadLine();
            //Printando mensagem na tela do usuário
            Console.Write("Haverá depósito inicial (s/n)? ");
            //variavel do tipo char (1 bit)
            char resp = char.Parse(Console.ReadLine());

            // Condicao para recerber valores char(string) maiuscula ou minuscula
            if (resp == 's' || resp == 'S')
            {

                Console.Write("Entre com o valor do deposito: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta_Bancaria(numero_conta, titular, saldo);

            }
            else {

                conta = new Conta_Bancaria(numero_conta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados Atualizado: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para o saque: ");
             quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
