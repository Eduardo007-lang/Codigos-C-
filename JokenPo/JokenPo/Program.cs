using System;

namespace JokenPo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine           ("JOKEN PO");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            
            Console.WriteLine("Suas Opções: ");
            Console.WriteLine("[0] Pedra");
            Console.WriteLine("[1] Papel");
            Console.WriteLine("[2] Tesoura");
            Console.WriteLine("---------------------------------");
            Console.Write("Jogador 1: ");
            int jogador1 = int.Parse(Console.ReadLine());
            Console.WriteLine("JO");
            Console.WriteLine("KEN");
            Console.WriteLine("PO!");
            Console.WriteLine("---------------------------------");
            Console.Write("Computador: ");
            Random joker = new Random();
            int computador = joker.Next(0,3);
            Console.WriteLine(computador);
            Console.WriteLine("---------------------------------");

            Console.ReadKey();



        }
    }
}
