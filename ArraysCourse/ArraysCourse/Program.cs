using System;
using System.Globalization;

namespace ArraysCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel do tipo inteiro
            int n = int.Parse(Console.ReadLine());
            //Vetor Produto de n tamanho
            Product[] vect = new Product[n];
            //Laço de repetição para adicionar os dados em cada posição do vetor
            for (int i = 0; i < n; i++) {

                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product(name, price);
            }

            //Variavel sum do tipo double inicializando com valor 0.0
            double sum = 0.0;
            //Laço de repetição para somar o preço dos produtos da classe Product
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            //Variavel avg recebendo o valor total adicionado na variavel sum e dividindo pelo valor da variavel n, resultando na média
            double avg = sum / n;
            //Mostrar o valor mediano dos produtos na tela 
            Console.WriteLine($"AVERAGE PRICE:{avg.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }

    }
}
