using System;

namespace Atividade1_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vect1 = new int[10];



            for (int i = 0; i < 10; i++)
            {

                vect1[i] = int.Parse(Console.ReadLine());

            }

            int[] vect2 = new int[10];

            for (int i = 0; i < 10; i++)
            {

                if (vect1[i] % 2 == 0)
                {

                    vect2[i] = vect1[i] * 2;

                }
                else if (vect1[i] % 2 == 1)
                {

                    vect2[i] = vect1[i] * 3;
                }

                Console.WriteLine(vect2[i]);
            }
        }
    }
}
