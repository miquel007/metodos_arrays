using System;

namespace ConsoleApp28
{
    class Program12
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            double suma = 0;

            for (int i = 0; i < 10; i++)
                array[i] = i;

            for (int i = 0; i < 10; i++)
            {
                suma = suma + array[i];
                Console.WriteLine("posicion {0} valor array {1}!", i, array[i]);
            }
  
            double media = suma / array.Length;
      
            Console.WriteLine("La media es {0}",media);
        }
    }
}
