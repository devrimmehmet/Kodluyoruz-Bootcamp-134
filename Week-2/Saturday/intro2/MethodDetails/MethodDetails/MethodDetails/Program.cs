using System;

namespace MethodDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = divide(12, 3);
            Console.WriteLine(result);
            int outputValue = 0;
            int result2 = divide(15, 2, out outputValue);
            Console.WriteLine($"Bölüm: {result2}, kalan: {outputValue}");
            int number = 8;
            sample(number);
            Console.WriteLine($"main metodundaki number değeri:{number}");
          
        }
        static int divide(int a, int b)
        {
            return a / b;
        }
        static int divide(int a, int b,out int modulo)
        {
            modulo = a%b;
            return a / b;
        }
        static void sample(int parameter)
        {
            parameter *=3;
            Console.WriteLine(parameter);
        }
        
    }
}
