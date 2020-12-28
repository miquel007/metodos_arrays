using System;

namespace ConsoleApp5
{
    class Program9
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Longitud de la array!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            int[] array = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Valor de la posicion!");
                string Mjoke = Console.ReadLine();
                num1 = Convert.ToInt32(Mjoke);
                array[i] = num1;
            }


            for (int i = 0; i < num; i++)
                Console.WriteLine("posicion {0} valor array {1}!", i, array[i]);

        }
    }
}
