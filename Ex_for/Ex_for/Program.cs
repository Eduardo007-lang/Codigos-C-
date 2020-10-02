using System;
using System.Globalization;

namespace Ex_for
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------ex001-------------------------------------------------------------------
            /*
             Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            X, se for o caso.

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++ ) {

                if (i % 2 != 0) { 

                    Console.WriteLine(i);

                } */


            // -----------------------------------------ex002-------------------------------------------------------------------

            /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
             

              int cont_in = 0;
             int cont_out = 0;

             int n = int.Parse(Console.ReadLine());

             for (int i = 0; i < n; i++) {

                 int x = int.Parse(Console.ReadLine());

                 if (x >= 10 && x <= 20)
                 {
                     cont_in = cont_in + 1;
                 }
                 else {
                     cont_out = cont_out + 1;
                 }

             }

             Console.WriteLine($"in:{cont_in}");
             Console.WriteLine($"out:{cont_out}");  */


            // -----------------------------------------ex003-------------------------------------------------------------------

            /*
             Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.

             

             double v1, v2, v3;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

              string[] vet = Console.ReadLine().Split(' ');
              v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
              v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
              v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

              double media = (v1 * 2.0 + v2 * 3.0 + v3 * 5.0) / 10;

              Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }*/

            // -----------------------------------------ex004-------------------------------------------------------------------

            /* 
             
             Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
             
             

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] vet = Console.ReadLine().Split(' ');
                int n1 = int.Parse(vet[0]);
                int n2 = int.Parse(vet[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão Impossivel");
                }
                else {

                    double div = (double) n1 / n2;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }*/

            // -----------------------------------------ex005-------------------------------------------------------------------


            /*
             Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.
             
        

             int n = int.Parse(Console.ReadLine());
             int fator = 1;
             for (int i = 1; i <= n; i++)
             {

                 fator = fator * i;

               

             }

             Console.WriteLine(fator);     */


            // -----------------------------------------ex006-------------------------------------------------------------------

            /* 

              Ler um número inteiro N e calcular todos os seus divisores.

          


            int n = int.Parse(Console.ReadLine());
     
           
            for (int i = 1; i <= n; i++) {


                if (n % i == 0) {
                    Console.WriteLine(i);
                }
                
            }*/


            /*
             Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme 
            exemplo.
             
            

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                int p = i;
                int s = i * i;
                int t = i * i * i;

                Console.WriteLine($"{p} {s} {t}");
            } */

        }
    }

}
