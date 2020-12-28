using System;

namespace ConsoleApp32
{
    class Program16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longitud de la array!");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            int[] array1 = new int[num];
            bool continuar = true;
            var rand = new Random();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Valor de la array!");
                string Mjoke = Console.ReadLine();
                int num1 = Convert.ToInt32(Mjoke);
                array1[i] = num1;
            }
                

            for (int i = 0; i < array1.Length/2; i++)
            {
                if (array1[i] != array1[array1.Length-i-1])
                {
                    continuar = false;
                    i = array1.Length;
                }
            }


            if (continuar)
                Console.WriteLine("La array es capicua");
            else
                Console.WriteLine("La array no es capicua");
        }
    }
}
