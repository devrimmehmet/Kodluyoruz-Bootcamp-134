using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sayı Tahmin Oyunu
             * 1. Program Rastgele bir sayı tutar.
             * 2. Kullanıcıdan bir tahmin istenir.
             * 3. Girilen tahmine göre aşağı yada yukarı biçiminde yönlendirilir.
             * 4. Sayı bilinene dek 2.Adıma dönülür.
             */

            bool isGameFinish = false;
            Random randomNumberGenerator = new Random(); //randomdan instance aldık.
            int randomNumber = randomNumberGenerator.Next(0, 100); //0 ile 100 arasında random sayı seç


            while (!isGameFinish)
            {
                //Kullanıcıdan Bir tahmin istenir
                Console.WriteLine("Tahmininizi Girin:");
                int guess = Convert.ToInt32(Console.ReadLine());


                //3.Girilen tahmine göre aşağı yada yukarı biçinde yönlendirilir.
                if (guess < randomNumber)
                {
                    Console.WriteLine("Yukarı!");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Aşağı!");
                }
                else
                {
                    Console.WriteLine("Bildiniz!");
                    isGameFinish = true;
                }
            }


        }
    }
}
