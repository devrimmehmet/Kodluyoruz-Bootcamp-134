using System;
using System.Collections.Generic;

namespace ArrayAndColections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////elemanları biliyorsanız
            //string[] shoppingList = new string[] { "Elma", "Salatalık", "Domates" };
            //Console.WriteLine($"İkinci eleman {shoppingList[1]}");

            //Console.WriteLine($"Array içindeki toplam eleman: {shoppingList.Length}");
            //Console.WriteLine($"Son eleman: {shoppingList[(shoppingList.Length-1)]}");


            ////elemanların sadece sayısını biliyorsam

            //string[] participants = new string[38];
            //participants[0] = "Abdullah Halit";
            //participants[1] = "Ahmad Hamdan";
            //participants[37] = "Umut Oku";


            // 42
            // kırk iki

            // string[] birler = new string[] { "", "Bir", "İki", "Üç","Dört","Beş","Altı","Yedi","Sekiz","Dokuz"};
            // string[] onlar = new string[] { "","On", "Yirmi", "Otuz","Kırk","Elli","Altmış","Yetmiş","Seksen","Doksan" };
            // int sayi=Convert.ToInt32(Console.ReadLine());
            // int birlerbas = sayi % 10;
            // int onlarbas = sayi / 10;
            //// Console.WriteLine(birlerbas);
            //// Console.WriteLine(onlarbas);
            // Console.WriteLine($"{onlar[onlarbas] } {birler[birlerbas]}");
            //ödev bütün sayıları okuyan bir algoritma 16.697.885



            //koleksiyona neden ihtiyaç duyarız ? Aşağıdaki kodu oku... ALTERNATİF GENERİC LİSTTİR...
            //string[] shoppingList = new string[] { "Elma", "Salatalık", "Domates" };
            //Array.Resize(ref shoppingList, shoppingList.Length + 1);
            //shoppingList[shoppingList.Length-1]="Peynir";

            //foreach(var item in shoppingList)
            //{
            //    Console.WriteLine(item);
            //}

            List<string> anotherShopList=new List<string>();
            anotherShopList.Add("Peynir");
            anotherShopList.Add("Zeytin");
            anotherShopList.Add("Su");
            foreach (var item in anotherShopList)
            {
                Console.WriteLine(item);
            }

            //birçok list türü var generic dictionary firsinfirstout vb...
        }
    }
}
