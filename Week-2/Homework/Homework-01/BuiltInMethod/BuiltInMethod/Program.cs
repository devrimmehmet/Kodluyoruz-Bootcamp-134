using System;
using System.Collections.Generic;

namespace BuiltInMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>() { "Ankara", "Ankara", "Ankara", "Sinop", "İstanbul", "İstanbul", "Eskişehir", "Ankara" };
            List<string> city = new List<string>() { }; // city adında yeni bir liste yarat
            foreach (var item in cities)
            {
                if (!city.Contains(item))//eğer city içinde yoksa item city içinde yoksa
                {
                    city.Add(item);//ekle 
                }
            }
            foreach (var item in city)//city içinde gez ve elemanları ekrana yazdır.
            {
                Console.WriteLine(item);
            }

            // İkinci Çözüm //
            /*
            //var city =cities.Distinct().ToList();
            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}
            // İkinci Çözüm //
             */


        }
    }
}
