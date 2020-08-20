using System;

namespace Atividade_4_Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

           num = int.Parse(Console.ReadLine());

       

            if (num % 2 == 0) {

                Console.WriteLine("Par");
            }
            else if (num % 2 == 1) {
                Console.WriteLine("impar");
            }
        }
    }
}
