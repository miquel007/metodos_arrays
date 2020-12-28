using System;

namespace ConsoleApp24
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero entero!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            bool primo = buscador(num);

            if (primo)
                Console.WriteLine("El numero es primo!");
            else
                Console.WriteLine("El numero no es primo!");
        }

        public static bool buscador (int num)
        {
            bool chek = true;
            int count = 2;
            int  op;

            while (count < num && chek)
            {
                op = num % count;
                Console.WriteLine("   "+op);


                if (op != 0)
                    count++;
                else
                    chek = false;
            }

            return chek;
        }
    }
}
