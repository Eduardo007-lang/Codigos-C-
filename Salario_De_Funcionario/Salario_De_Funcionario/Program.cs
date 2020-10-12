using System;
using System.Globalization;

namespace Salario_De_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis func do tipo funcionario, recebendo os atributos da classe/objeto
            Funcionario func1,func2;

            //instanciando a classe/Objeto funcionario 
            func1 = new Funcionario();
            func2 = new Funcionario();

            //Inserindo dados do primeiro funcionario, nome e salario
            Console.WriteLine("Dados do Primeiro Funcionario; ");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            func1.Sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Inserindo dados do segundo funcionario, nome e salario
            Console.WriteLine("Dados do Primeiro Funcionario; ");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            func2.Sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salmedio = (func1.Sal + func2.Sal) / 2;

            Console.WriteLine($"Salario Medio: {salmedio.ToString("F2", CultureInfo.InvariantCulture)}");






        }
    }
}
