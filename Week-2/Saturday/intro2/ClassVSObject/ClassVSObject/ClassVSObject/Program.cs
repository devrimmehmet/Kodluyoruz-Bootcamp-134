using System;

namespace ClassVSObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Person student1 = new Person();
            student1.Name = "Ahmed Jam";

            Person student2 = student1;
            student2.Name = "İrem Ergin";

            Console.WriteLine(student1.Name);

            /*
             * Musteri musteri = new Musteri();
             * Yemek sandvic=new Yemek();
             * Sepet yemekSepeti=new Sepet();
             * yemekSepeti.Ekle(sandvic);
             * musteri.SiparisVer(yemekSepeti);
             * 
             */

            Console.WriteLine();
        }
    }
}
