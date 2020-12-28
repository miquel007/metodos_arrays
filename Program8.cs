using System;

namespace ConsoleApp4
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longitud de la array!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            int[] array = new int[num];

            for (int i = 0; i < num; i++)
                array[i] = i;

            for (int i = 0; i < num; i++)
                Console.WriteLine("posicion {0} valor array {1}!", i, array[i]);

        }
    }
}
