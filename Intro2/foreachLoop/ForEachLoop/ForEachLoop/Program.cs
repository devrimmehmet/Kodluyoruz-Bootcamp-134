using System;
using System.Collections.Generic;

namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            products.Add("Samsung A51");
            products.Add("Xiaomi");
            products.Add("Oppo");
            products.Add("IPhone");

            List<string> storage = new List<string>();
            
            foreach (string product in products) //foreach ile dolaşırken kaynak fonksiyonunuza müdahale edemezsiniz  !!!
            {
                if(product.StartsWith("I"))
                {
                    storage.Add(product);
                    
                    // products.Remove(product);
                }
                
            }
            foreach (var item in storage)
            {
                
                products.Remove(item);//product taki elemanı kaldırmak için storagedeki elemanı productan kaldır diyoruz storagenin içinde dolaşırken yapabiliyoruz.
            }

            foreach (var product in products)
            {
                Console.WriteLine(product);//product taki elemanı kaldırmak için storagedeki elemanı productan kaldır diyoruz storagenin içinde dolaşırken yapabiliyoruz.
            }
        }
    }
}
