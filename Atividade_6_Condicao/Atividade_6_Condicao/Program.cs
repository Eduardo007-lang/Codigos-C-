using System;

namespace Atividade_6_Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrevendo na tela a mensagem "Digite o ano de nascimento: "
            Console.Write("Digite o ano de nascimento: ");
            //Fazendo leitura do que foi digitado e armazenando na variavel "nascimento"
            int nascimento = int.Parse(Console.ReadLine());

            //Variavel alistamento recebendo o valor do calculo do ano de 2020 - o valor armazenado na variavel "nascimento"
            int alistamento = 2020 - nascimento;
            //Condicao se o valor armazendo dentro da variavel alistamento for < 18 entao Escrevera na tela quantos anos restam para fazer o alistamento 
            if (alistamento < 18)
            {


                int restante = 18 - alistamento;

                Console.WriteLine($"Restam: {restante} anos para o alistamento!");

            }
            // Se o resultado do alistamento for maior que 18 Escrevera na tela os anos que se passou pos alistamento
            else if (alistamento > 18)
            {

                int restante = alistamento - 18;

                Console.WriteLine($"Já se passou, {restante} anos para o alistamento!");

            }
            // se não for maior que 18  nem menor que 18, Escrevera na tela que esta na hora de se alistar! 
            else {

                Console.WriteLine("Hora de se alistar!");
            }
           
        }
    }
}
