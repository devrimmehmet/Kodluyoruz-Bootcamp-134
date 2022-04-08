using System;
using System.Collections.Generic;
using System.Linq;
namespace BuiltInMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int index = 0;
            //int sayac = 0;
            //Console.WriteLine("Kelimenizi Girin");
            //string word = Console.ReadLine();
            //Console.WriteLine("kelimenizde aramak istediğiniz harfi giriniz");
            //string search = Console.ReadLine();
            //while (index!=-1) 
            //{
            //    if (index != -1)
            //    {
            //        index = word.IndexOf(search, index + 1);
            //        sayac += 1;
            //    }

            //}  
            //Console.WriteLine($"Yazdığınız kelimenin içinde aradığınız harf ({search}) kelimenizin içinde {sayac} tane var.");




            /*
             Başka bir örnek
             */
            //List<string> emails = new List<string>()
            //{
            //    "turkay.urkmez@dinamikzihin.com",
            //    "kirikkalp72@yahoo.com",
            //    "nur.bilge@microsoft.com",
            //    "turkay.urkmez@gmail.com",
            //    "babyboy@mynet.com",
            //    "testdenemea"

            //};


            //List<string> publicDomains = new List<string>()
            //{
            //    "yahoo.com",
            //    "gmail.com",
            //    "mynet.com"
            //};

            //List<string> companyEmails = new List<string>();


            //foreach (string mail in emails) 
            //{   
            //    string[] mailParts=mail.Split('@');

            //    if (mailParts.Length > 1) {
            //    string mailDomain =mailParts[1];
            //    bool isExists = publicDomains.Contains(mailDomain);
            //    if (!isExists) 
            //    {
            //        companyEmails.Add(mail);
            //    }
            //    }
            //}
            //Console.WriteLine("Şirket Mail adresleri");
            //foreach (string emailadress in companyEmails) 
            //{
            //    Console.WriteLine(emailadress);
            //}


            //List<string> cities = new List<string>() { "Ankara", "Ankara", "Ankara", "Sinop", "İstanbul", "İstanbul", "Eskişehir", "Ankara" };
            //string search = "";

            //int index = 0;
            //List<string> myCities = new List<string>();
            //for (int i = 0; i < cities.Count; i++)
            //{
            //    myCities.Add(cities[i]);
            //    while (index != -1)
            //    {
            //        if (index != -1)
            //        {
            //            index = cities.IndexOf(cities[i], i);
            //            cities.Remove(cities[i]);

            //        }

            //    }



            //}

            //foreach (string c in cities)
            //{
            //    Console.WriteLine(c);
            //}

           
          
            List<string> cities = new List<string>() { "Ankara", "Ankara", "Ankara", "Sinop", "İstanbul", "İstanbul", "Eskişehir", "Ankara" };

            //var city =cities.Distinct().ToList();
            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}

            List<string> city = new List<string>() { };

            city.Add(cities[0]);

            foreach (var item in cities)
            {
                if (!city.Contains(item))
                {
                    city.Add(item);
                }
            }
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

        }
    }
}
