using System;

namespace ConsoleApp31
{
    class Program15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longitud de la array!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            int[] array1 = new int[num];
            int[] array2 = new int[num];
            bool trobat = false;
            var rand = new Random();

            for (int i = 0; i < num; i++)
                array1[i] = rand.Next(1, 10);

            for (int i = 0; i < array1.Length; i++)
            {
                array2[array2.Length-i-1] = array1[i];
            }


            for (int i = 0; i < array1.Length; i++)
                Console.WriteLine("posicion {0} valor array {1}!", i, array1[i]);

            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine("posicion {0} valor array {1}!", i, array2[i]);

        }
    }
}
