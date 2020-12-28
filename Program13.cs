using System;

namespace ConsoleApp29
{
    class Program13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longitud de la array!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);


            int[] array = new int[num];
            int suma = 0;
            var rand = new Random();
 


            for (int i = 0; i < num; i++)
                array[i] = rand.Next(1, 10);

            for (int i = 0; i < num; i++)
            {
                suma = suma + array[i];
                Console.WriteLine("posicion {0} valor array {1}!", i, array[i]);
            }

            Console.WriteLine("La suma total es " + suma);
        }
    }
}
