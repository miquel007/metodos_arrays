using System;

namespace ConsoleApp23
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos numero quieres generar (enteros)?");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            Console.WriteLine("Valor minimo que quieres generar?");
            string Mjoke = Console.ReadLine();
            int min = Convert.ToInt32(Mjoke);

            Console.WriteLine("Valor maximo que quieres generar?");
            string Ljoke = Console.ReadLine();
            int max = Convert.ToInt32(Ljoke);

            generador(num, min, max);
        }

        public static void generador(int num, int min, int max)
        {
            var rand = new Random();
            for (int i=0; i < num; i++)
                Console.Write("{0,8:N0}", rand.Next(min, max));

        }
    }
}
