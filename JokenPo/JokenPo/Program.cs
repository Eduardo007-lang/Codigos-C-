using System;

namespace JokenPo
{
    class Program
    {
        static void Main(string[] args)
        {
            // variaveis
            int count = 1, quantidade = 0;
           

            //titulo 
            Console.WriteLine("---------------------------------");
            Console.WriteLine           ("JOKEN PO");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            //Opções do Usuário pro jogo
            Console.WriteLine("Suas Opções: ");
            Console.WriteLine("[0] Pedra");
            Console.WriteLine("[1] Papel");
            Console.WriteLine("[2] Tesoura");
            Console.WriteLine("---------------------------------");

            //Condição para quantas partidas o usuario deseja jogar
            Console.Write("Quantas partidas deseja jogar?:  ");
            quantidade = int.Parse(Console.ReadLine());
            while (count <= quantidade)
            {
                //Lançe do jogador de 0 até 2 
                Console.WriteLine($"Jogo {count}o ;") ;
                Console.Write("Jogador 1: ");
                int jogador1 = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------");

                //Função para gerar numero aleatorio de 0 até 2 
                Console.Write("Computador: ");
                Random joker = new Random();
                int computador = joker.Next(0, 2);
                Console.WriteLine(computador);
                Console.WriteLine("---------------------------------");

                if (computador == 0)//Computador jogou Pedra
                    if (jogador1 == 0)
                    {
                        Console.WriteLine("E M P A T E");
                    }
                    else if (jogador1 == 1)
                    {
                        Console.WriteLine("Jogador1 VENCE!!!");
                    }
                    else if (jogador1 == 2)
                    {
                        Console.WriteLine("Computador VENCE!!!");
                    }
                    else {
                        Console.Write("Jogada INVALIDA");
                    }
                        
                else if (computador == 1)// Computador jogou Papel 
                    if (jogador1 == 0)
                    {
                        Console.WriteLine("Computador VENCE!!!");
                    }
                    else if (jogador1 == 1)
                    {
                        Console.WriteLine("E M P A T E");
                    }
                    else if (jogador1 == 2)
                    {
                        Console.WriteLine("jogador1 VENCE!!!");
                    }
                    else
                    {
                        Console.Write("Jogada INVALIDA");
                    }
                else if (computador == 2)// Computador jogou Tesoura;
                    if (jogador1 == 0)
                    {
                        Console.WriteLine("Jogador1 VENCE!!!");
                    }
                    else if (jogador1 == 1)
                    {
                        Console.WriteLine("Computador VENCE!!!");
                    }
                    else if (jogador1 == 2)
                    {
                        Console.WriteLine("E M P A T E");
                    }
                    else
                    {
                        Console.WriteLine("Jogada INVALIDA");
                    }

                count++;
            }
            Console.ReadKey();



        }
    }
}
