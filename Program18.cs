using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
    class Program18
    {
        static void Main(string[] args)
        {
            List<int> array = Rellenar();

            mostrar(array);
        }

        public static List<int> Rellenar()
        {
            Console.WriteLine("Longitud de la array!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            List<int> array = new List<int>();

            for (int i = 0; i < num; i++)
                array.Add(Random());
           

            return array;
        }
        private static int Random()
        {
            var rand = new Random();

            return rand.Next(0, 9);
        }

        public static void mostrar(List<int> array)
        {
            int suma = 0;
            foreach (int num in array)
            {
                Console.WriteLine(num);
                suma = suma + num;
            }

            Console.WriteLine(suma);
        }

    }
}
