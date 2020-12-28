using System;

namespace ConsoleApp25
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero entero!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

           factorial(num);

        }

        public static void factorial(int num)
        {
       
     
            int op = 1;

            while (0 < num )
            {
                op = op * num;

                num--;

            }

            Console.WriteLine("El factorial es " + op);
        }
    }
}