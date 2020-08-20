using System;

namespace Atividade_9_Desafio_Segmento_Reta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro tamanho da reta:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo tamanho da reta:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro tamanho da reta:");
            int c = int.Parse(Console.ReadLine());

            bool triangulo = (a < b + c) && (b < c + a) && (c < a + b);

            if (triangulo == true)
            {

                Console.WriteLine("Forma um triangulo");
            }
            else {

                Console.WriteLine("Não forma um triangulo");
            }
        }
    }
}
