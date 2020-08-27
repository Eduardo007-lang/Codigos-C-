using System;

namespace Departamento_Transito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("DEPARTAMENTO DE TRANSITO");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("Qual ano estamos(yyyy): ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Qual ano voce nasceu(yyyy): ");
            int nascimento = int.Parse(Console.ReadLine());

            int idade = ano - nascimento;

            Console.WriteLine();
            if (idade >= 18)
            {
                Console.WriteLine("---------------STATUS--------------");
                Console.WriteLine($"IDADE:{idade} anos");
                Console.WriteLine("HAPTO A TIRAR A CARTEIRA");
            }

            else
            {
                Console.WriteLine("---------------STATUS--------------");
                Console.WriteLine($"IDADE:{idade} anos");
                Console.WriteLine("INAPTO A TIRAR A CARTEIRA");

            }
            
        }
    }
}
