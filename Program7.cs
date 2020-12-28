using System;

namespace ConsoleApp3
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cantidad que desea convertir");
            string Njoke = Console.ReadLine();
            double num = Convert.ToDouble(Njoke);

            Console.WriteLine("A que moneda desea convertir(escribe numero)? 1)Libras 2)Dolares 3)Yenes ");
            string Mjoke = Console.ReadLine();
            int opcion = Convert.ToInt32(Mjoke);

            switch (opcion)
            {
                case 1:
                    Convertor(num, "Libras");
                    break;
                case 2:
                    Convertor(num, "Dolares");
                    break;
                case 3:
                    Convertor(num, "Yenes");
                    break;
                default:
                    Console.WriteLine("Pringui");
                    break;
            }

        }

        public static void Convertor(double cantidad, string moneda)
        {

            double num = 0;
            double convert;

            switch (moneda)
            {
                case "Libras":
                    num = 0.86;
                    break;
                case "Dolares":
                    num = 1.28611;
                    break;
                case "Yenes":
                    num = 129.852;
                    break;
                
            }

            convert = cantidad * num;

            Console.WriteLine("La conversion es  " + Math.Round(convert,4));

        }
    }
}
