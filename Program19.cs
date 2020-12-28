using System;
using System.Collections.Generic;

namespace ConsoleApp35
{
    class Program19
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

            Console.WriteLine("Numero minimo de la array!");
            string Mjoke = Console.ReadLine();
            int min = Convert.ToInt32(Mjoke);

            Console.WriteLine("Numero maximo de la array!");
            string Ljoke = Console.ReadLine();
            int max = Convert.ToInt32(Ljoke);

            List<int> array = new List<int>();

            for (int i = 0; i < num; i++)
                array.Add(Random(min,max));


            return array;
        }

        private static int Random(int min,int max)
        {
            var rand = new Random();
            int num = rand.Next(min, max);

            bool primo = Primo(num);
            if (!primo)
            {
                while (!primo)
                {
                    num = rand.Next(min, max);
                    primo = Primo(num);
                }
            }

            return num;
        }

        public static bool Primo (int num)
        {
            bool chek = true;
            int count = 2;
            int op;

            while (count < num && chek)
            {
                op = num % count;

                if (op != 0)
                    count++;
                else
                    chek = false;
            }

            return chek;
        }

        public static void mostrar(List<int> array)
        {
            int suma = 0;
            int max = 0;
            foreach (int num in array)
            {
                Console.WriteLine(num);
                if (max < num)
                    max = num;
            }

            Console.WriteLine(max);
        }

    }
}
