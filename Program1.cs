using System;

namespace ConsoleApp22
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que area quieres calcular (escribe numero)? 1)Circulo  2)Triangulo  3)Cuadrado");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);


            bool chek = true;
            double op = 0;


            switch (num)
            {
                case 1:
                    op = Circulo(); 
                    break;
                case 2:
                    op = Triangulo();
                    break;
                case 3:
                    op = Cuadrado();
                    break;
                default:
                    Console.WriteLine("Que no sabes escribir?");
                    chek = false;
                    break;
            }


            if (chek)
                Console.WriteLine("La area del objeto es  " + Math.Round(op,2));

        }

        public static double Circulo ()
        {
            Console.WriteLine("Radio del circulo");
            string Njoke = Console.ReadLine();
            double radio = Convert.ToDouble(Njoke);

            double op = Math.Pow(radio, 2) * Math.PI;

            return op;
        }

        public static double Triangulo()
        {
            Console.WriteLine("Base del triangulo");
            string Njoke = Console.ReadLine();
            double basse = Convert.ToDouble(Njoke);

            Console.WriteLine("Altura del triangulo");
            string Mjoke = Console.ReadLine();
            double altura = Convert.ToDouble(Mjoke);

            double op = (basse * altura) / 2;

            return op;
        }


        public static double Cuadrado()
        {
            Console.WriteLine("Lado del cuadrado");
            string Njoke = Console.ReadLine();
            double lado = Convert.ToDouble(Njoke);


            double op = Math.Pow(lado,2);

            return op;
        }

    }
}
