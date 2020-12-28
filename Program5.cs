using System;

namespace ConsoleApp1
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero entero!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            string binario = convertir(num);

            Console.WriteLine("El numero en binari es " + binario);
        }

        public static string convertir(int num)
        {
            bool chek = true;
            string resultat = "";
            int count = 2;
            int op;

            while (0 < num)
            {
                op = num % count;

                num = num / 2;
                if (op == 0)
                    resultat = "0" + resultat ;
                else
                    resultat = "1" + resultat ;
            }

            return resultat;
        }
    }
}