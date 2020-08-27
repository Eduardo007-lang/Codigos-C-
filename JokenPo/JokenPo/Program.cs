using System;

namespace JokenPo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("JOKENPO");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Jogador 1 - Escolhe entre: (Pedra, Papel e Tesoura) ");
            string j1 = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Jogador 2 - Escolhe entre: (Pedra, Papel e Tesoura) ");
            string j2 = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");
            if (j1 == "Pedra" && j2 == "Tesoura" || j1 == "Tesoura" && j2 == "Pedra")
            {
                Console.WriteLine($"Jogador 1:{j1} ");
                Console.WriteLine($"Jogador 2:{j2} ");
                Console.WriteLine("Pedra Ganha!");
            }
            else if (j1 == "Papel"  && j2 == "Tesoura" || j1 == "Tesoura" && j2 == "Pedra")
            {

                Console.WriteLine($"Jogador 1:{j1} ");
                Console.WriteLine($"Jogador 2:{j2} ");
                Console.WriteLine("Tesoura Ganha!");
            }
            else if (j1 == "Papel" && j2 == "Pedra" || j1 == "Pedra" && j2 == "Papel") {

                Console.WriteLine($"Jogador 1:{j1} ");
                Console.WriteLine($"Jogador 2:{j2} ");
                Console.WriteLine("Papel Ganha!");
            }
            else
            {

                Console.WriteLine("EMPATE");
            }



        }
    }
}
