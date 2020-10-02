using System;
using System.Globalization;

namespace Pesquisa_SO_Servidores
{
    class Program
    {
        static void Main(string[] args)
        {

             
            //variaveis
            int escolha = 0, win = 0,
                unix = 0, linux = 0,
                netware = 0, macOs = 0, outros = 0;

           

            Console.WriteLine("----------------------------");
            Console.WriteLine("       FIM DA PESQUISA !    ");
            Console.WriteLine("----------------------------");

            //Escrever na tela quantas pesquisa o usuario deseja fazer 
            Console.Write("Digite quantas pesquisas deseja fazer: ");

            //saltar linha
            Console.WriteLine();

            //numero de pesquisa que será feita 
            int n = int.Parse(Console.ReadLine());

            //Para
            for (int count = 0; count <= n; count++)
            {

                //saltar linha
                Console.WriteLine();
                Console.WriteLine("Qual melhor Sistema Operacional(SO) para servidores ?: ");
               

                //saltar linha 
                Console.WriteLine();

                //Opçoes do Usuario
                Console.WriteLine("[1] Para Windows.");
                Console.WriteLine("[2] Para Unix.");
                Console.WriteLine("[3] Para Linux.");
                Console.WriteLine("[4] Para NetWare.");
                Console.WriteLine("[5] Para MacOS.");
                Console.WriteLine("[6] Outros.");
                Console.WriteLine("[0] Para Sair.");
                escolha = int.Parse(Console.ReadLine());

                // Se escolha for menor que 0 e maior que 6, repitira o codigo
                if (escolha < 0 || escolha > 6) {

                    Console.WriteLine("DIGITE APENAS NUMEROS DE 0 A 6 CITADAS NAS OPÇÕES ABAIXO!!!");
                 
                }

                    switch (escolha)
                    {
                        //caso
                        case 1:
                            win = win + 1;
                            break;
                        case 2:
                            unix = unix + 1;
                            break;
                        case 3:
                            linux = linux + 1;
                            break;
                        case 4:
                            netware = netware + 1;
                            break;
                        case 5:
                            macOs = win + 1;
                            break;
                        case 6:
                            outros = outros + 1;
                            break;
                        case 0:
                            Console.WriteLine("Saindo da pesquisa...");
                            break;

                    }
                 
            }
            //motrando mensagem na tela 
            Console.WriteLine("----------------------------");
            Console.WriteLine("       FIM DA PESQUISA !    ");
            Console.WriteLine("----------------------------");

            //Saltar linha
            Console.WriteLine();

            //mostrando a quantidade de votos para cada sistema operacional 
            Console.WriteLine($"Sistemas Windows: {win}");
            Console.WriteLine($"Sistemas Unix: {unix}");
            Console.WriteLine($"Sistemas Linux: {linux}");
            Console.WriteLine($"Sistemas NetWare: {netware}");
            Console.WriteLine($"Sistemas MacOS: {macOs}");
            Console.WriteLine($"Outros Sistemas: {outros}");

            //Saltar linha
            Console.WriteLine();

            //mostrando mensagem na tela 
            Console.WriteLine("--------------------------------");
            Console.WriteLine("    PORCENTUAL DAS PESQUISAS    ");
            Console.WriteLine("--------------------------------");

            //calculo porcentual
            double totwindows = n * win / 100;
            double totunix = n * unix / 100;
            double totlinux = n * linux / 100;
            double totnet = n * netware / 100;
            double totmacOs = n * macOs / 100;
            double totoutros = n * outros / 100;

            Console.WriteLine($" De {n} pesquisa, {totwindows.ToString("F1",CultureInfo.InvariantCulture)} % votaram para Windows ");
            Console.WriteLine($" De {n} pesquisa, {totunix.ToString("F1", CultureInfo.InvariantCulture)} % votaram para Unix ");
            Console.WriteLine($" De {n} pesquisa, {totlinux.ToString("F1", CultureInfo.InvariantCulture)} % votaram para Linux ");
            Console.WriteLine($" De {n} pesquisa, {totnet.ToString("F1", CultureInfo.InvariantCulture)} % votaram para Netware ");
            Console.WriteLine($" De {n} pesquisa, {totmacOs.ToString("F1", CultureInfo.InvariantCulture)} % votaram para MacOS ");
            Console.WriteLine($" De {n} pesquisa, {totoutros.ToString("F1", CultureInfo.InvariantCulture)} % votaram para outros ");

        }
    }            
}

