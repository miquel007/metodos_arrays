using System;
using System.Collections.Generic;

namespace ConsoleApp33
{
    class Program17
    {
        static void Main(string[] args)
        {
           
            bool continuar = true;
            var rand = new Random();

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
            {
                Console.WriteLine("Valor de la array!");
                string Mjoke = Console.ReadLine();
                int num1 = Convert.ToInt32(Mjoke);
                array.Add(num1);
            }

            return array;
        }

        public static void mostrar(List<int> array)
        {
            foreach (int num in array)
                Console.WriteLine(num);
        }

    }
}
