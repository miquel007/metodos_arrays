using System;
using System.Collections.Generic;

namespace ConsoleApp37
{
    class Program21
    {
        static void Main(string[] args)
        {
            List<int> array = Rellenar();

            mostrar(array);

            List<int> array2 = filtrar(array);

            mostrar(array2);
        }
        
        public static List<int> filtrar(List<int> array)
        {
            Console.WriteLine("numero que debe finalizar");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            while (num > 10)
            {
                Console.WriteLine("numero que debe finalizar");
                Njoke = Console.ReadLine();
                num = Convert.ToInt32(Njoke);
            }

            List<int> array2 = new List<int>();
            int filtre = 0;

            foreach (int num1 in array)
            {
                filtre = num1 % 10;
                if (filtre == num)
                    array2.Add(num1);
            }

            return (array2);
        }

        public static List<int> Rellenar()
        {
            Console.WriteLine("Longitud de la array!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);


            List<int> array = new List<int>();

            for (int i = 0; i < num; i++)
                array.Add(Random(1, 300));

            return array;
        }

        private static int Random(int min, int max)
        {
            var rand = new Random();
            int num = rand.Next(min, max);

            return num;
        }

        public static void mostrar(List<int> array)
        {
            Console.WriteLine("");

            foreach (int num in array)
                Console.WriteLine(num);

            

            Console.WriteLine("");
        }

    }
}