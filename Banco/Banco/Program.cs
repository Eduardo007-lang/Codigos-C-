using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta_Bancaria conta = new Conta_Bancaria(0000, "Nome", 00.00 );

            Console.WriteLine("Entre o número da conta: ");
            conta.numero_conta = int.Parse(Console.ReadLine());
        }
    }
}
