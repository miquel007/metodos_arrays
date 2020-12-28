using System;
using System.Collections.Generic;

namespace ConsoleApp36
{
    class Program20
    {
        static void Main(string[] args)
        {
            bool first = true;

            List<int> array1 = Rellenar(first,0);
            first = false;

            List<int> array2 = array1;

            array1 = Rellenar(first,array1.Count);

            mostrar(array1);

            mostrar(array2);

            List<int> array3 = Multiplicar(array1, array2);

            mostrar(array3);

        }

        public static List<int> Multiplicar(List<int>array1, List<int>array2)
        {
            List<int> array = new List<int>();

            for(int i = 0; i< array1.Count;i++)
                array.Add(array1[i] * array2[i]);

            return array;
        }

        public static List<int> Rellenar(bool preguntar, int llarg)
        {
            int num = 0;
            if (preguntar)
            {
                Console.WriteLine("Longitud de la array!");
                string Njoke = Console.ReadLine();
                num = Convert.ToInt32(Njoke);
            }

            Console.WriteLine("Numero minimo de la array!");
            string Mjoke = Console.ReadLine();
            int min = Convert.ToInt32(Mjoke);

            Console.WriteLine("Numero maximo de la array!");
            string Ljoke = Console.ReadLine();
            int max = Convert.ToInt32(Ljoke);

            List<int> array = new List<int>();

            if (preguntar)
            {
                for (int i = 0; i < num; i++)
                    array.Add(Random(min, max));
            }
            else
                for (int i = 0; i < llarg; i++)
                    array.Add(Random(min, max));

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
            int suma = 0;
            int max = 0;

            Console.WriteLine("");


            foreach (int num in array)
            {
                Console.WriteLine(num);
                if (max < num)
                    max = num;
            }

            Console.WriteLine("");


        }

    }
}
