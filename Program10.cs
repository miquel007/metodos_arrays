using System;

namespace ConsoleApp26
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero a jugar!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            int[] array = new int[11];

            for (int i = 0; i < 11; i++)
                array[i] = num*i;

            for (int i = 0; i < 11; i++)
                Console.WriteLine("posicion {0} valor array {1}!", i, array[i]);

        }
    }
}
