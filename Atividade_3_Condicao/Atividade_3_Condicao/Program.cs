using System;
using System.Globalization;

namespace Atividade_3_Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            double n1 = 0, n2 = 0, media = 0;
            //Escrevendo na tela a mensagem " Nome do aluno:"
            Console.Write("Nome do Aluno: ");

            //Lendo o que foi digitado pelo usuario e armazenando na variavel Aluno
            string Aluno = Console.ReadLine();

            //Escrevendo na tela a mensagem "Digite a Primeira nota:"
             Console.Write("Digite a Primeira nota: ");

            //Lendo o que foi digitado pelo usuario e armazenando na variavel n1
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Escrevendo na tela a mensagem "Digite a Segunda nota:"
            Console.Write("Digite a Segunda nota: ");

            //Lendo o que foi digitado pelo usuario e armazenando na variavel n2
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Saltando uma linha 
            Console.WriteLine();

            //Calculo da media da soma de n1 e n2
            media = (n1 + n2) / 2;
           
            Console.WriteLine("-----------------------------------------");
            //Escrevendo na tela o nome do aluno que esta armazenado na variavel "Aluno" saltando uma linha e Escrevendo o resuldado da media da soma das duas notas 
            Console.WriteLine($"Nota Final do Aluno:{Aluno} \n Nota:{media.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("-----------------------------------------");
            //Verificando se a nota do aluno foi maior ou igual a 7.0, se sim mostrar que o aluno teve um bom apreveitamento, se não mostrara que não teve um bom aproveitamento 
            if (media >= 7.0)
            {
                Console.WriteLine($"O Aluno {Aluno} teve um Bom aproveitamento!");
            }
            else {
                Console.WriteLine($"O Aluno {Aluno} Não teve um bom aproveitamento!");
            }
            Console.ReadKey();




        }
    }
}
