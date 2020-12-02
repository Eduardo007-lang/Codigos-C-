using System;
using System.Globalization;

namespace Pessoa_Fisica
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia particular da classe
            Pessoa p;

            //Mostrar mensagem na tela do Usuário
            Console.Write("Nome: ");
            //variavel nome do tipo string
            string nome = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            //variavel dataNascimento do tipo DataTime
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            //variavel altura do tipo double 
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Criando um objeto p com paramentros de entrada 
            p = new Pessoa(nome, dataNascimento, altura);

            //Saltar linha 
            Console.WriteLine();
            //Printando o valores do objeto p na tela do usuário 
            Console.WriteLine(p);

        }
    }
}
