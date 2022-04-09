using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            //showOutput("Kodluyoruz bootcamp çok iyi :)");
            //int[] numbers = { 12, 9, 25, 36, 0, 22 };
            //int average = getAverage(numbers.ToList());
            //// Console.WriteLine(average.ToString()) ;
            //showOutput($"Ortalama Sayı: {average}");

            if (isPrime(13))
            {
                Console.WriteLine("13 sayısı asaldır");
            }
        }

        //static void showOutput(string message) 
        //{
        //    Console.WriteLine(message);
        //}
        //static int getAverage(List<int> numbers) 
        //{
        //    int total = 0;
        //    foreach (var number in numbers)
        //    {
        //        total += number;
        //    }
        //    return total/numbers.Count;
        //}


        static bool isPrime(int number) 
        {
            //kendisinden ve birden başka hiçbir sayıya bölünemeyen sayılara asal sayı denir.
            bool isPrimeValue = true; //dışarda tanıma içerde değer döndür buna flag deniliyor.
            for (int i = 1; i < number; i++)
            {
                if (number% i==0) 
                {
                   isPrimeValue = false;
                }
            }

            return isPrimeValue;

        }

    }
}
