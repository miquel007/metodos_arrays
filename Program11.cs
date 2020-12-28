using System;

namespace ConsoleApp27
{
    class Program11
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int suma = 0;

            for (int i = 0; i < 10; i++)
                array[i] = i;

            for (int i = 0; i < 10; i++)
            {
                suma = suma + array[i];
                Console.WriteLine("posicion {0} valor array {1}!", i, array[i]);
            }

            Console.WriteLine("La suma total es " + suma);
        }
    }
}