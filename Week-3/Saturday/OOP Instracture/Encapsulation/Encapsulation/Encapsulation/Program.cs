using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //encapsulation decapsulation
            Console.WriteLine("Hello World!");
            Product kolye=new Product();
            kolye.SetPrice(15);
            Console.WriteLine(kolye.GetPrice());
            kolye.Name = "Art 1";
            kolye.StockCount = 1000;

        }
    }
}
