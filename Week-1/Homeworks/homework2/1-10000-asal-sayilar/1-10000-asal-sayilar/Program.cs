
using System;

namespace _1_10000_asal_sayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int sayi = 2; sayi <= 10000; sayi++)
            {
                int kontrol = 0;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                }


                if (kontrol == 1)
                {

                }
                else
                {
                    Console.Write($"{sayi},");

                }
            }


        }
    }
}

