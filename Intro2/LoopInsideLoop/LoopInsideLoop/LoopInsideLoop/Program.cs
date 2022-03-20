using System;

namespace LoopInsideLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Çarpım Tablosu yazdırma
             */

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j}");
                }
                Console.WriteLine("**************************");
            }
        }
    }
}
