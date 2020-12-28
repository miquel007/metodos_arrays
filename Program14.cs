using System;

namespace ConsoleApp30
{
    class Program14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longitud de la array!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            int[] array = new int[num];
            bool trobat = false;
            var rand = new Random();

            for (int i = 0; i < num; i++)
                array[i] = rand.Next(1, 10);

            Console.WriteLine("Escribe un numero entre 1 y el 10!");
            string Mjoke = Console.ReadLine();
            int random = Convert.ToInt32(Mjoke);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == random)
                {
                    trobat = true;
                    i = array.Length;
                }
            }

            if (trobat)
                Console.WriteLine("La busqueda a estat exitosa");
            else
                Console.WriteLine("La busqueda no a estat exitosa");

            for (int i = 0; i < 10; i++)            
                Console.WriteLine("posicion {0} valor array {1}!", i, array[i]);
            
        }
    }
}

