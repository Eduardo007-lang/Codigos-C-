using System;

namespace Atividade_2_Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());

            int calculoidade =  2020 - nascimento;

            if (calculoidade >= 16)
            {

                Console.WriteLine("Pode votar!");
            }
            else 
            {
                Console.WriteLine("Não pode votar!");
            }
        }
    }
}
