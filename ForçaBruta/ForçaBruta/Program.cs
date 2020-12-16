using System;

namespace ForçaBruta
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();

            int[] array = new int[9999];


            for (int i = 0; i < array.Length; i++) {

                int arrayInt = numAleatorio.Next(0, 9999);

                for (int j = 0; j < array.Length; i++)

                    if (array[i] == array[j]) {
                        
                    }

                        array[i] = arrayInt;

                        Console.WriteLine(array[i]);
            }

           // Console.WriteLine(array);
        }
    }
}
