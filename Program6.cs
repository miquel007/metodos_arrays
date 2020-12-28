using System;

namespace ConsoleApp2
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero entero!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            int  tamaño = contador(num);

            Console.WriteLine("El numero tiene tamaño " + tamaño);
        }

        public static int contador(int num)
        {
            int count = 0;
            double increment = 10;

            while (increment < num)
            {
                count++;
                increment = Math.Pow(10, count);
            }

            return (count);
        }
    }
}