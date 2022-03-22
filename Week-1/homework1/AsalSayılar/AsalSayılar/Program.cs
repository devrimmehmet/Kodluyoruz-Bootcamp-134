using System;

namespace AsalSayılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        DMP:
            try
            {

                int check = 0;
                Console.Write("1'den büyük bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 1 || sayi == 0)
                {
                    Console.WriteLine("Girdiğiniz sayı asal değildir. Ve 1'den küçük sayılar girdiniz.");

                }
                else if (sayi > 1)
                {
                    for (int i = 2; i < sayi / 2; i++)
                    {
                        if (sayi % i == 0) //Kalansız bölünüyormu?
                        {
                            check++;
                            break; //Diğer sayılara bakmaya gerek duymuyoruz.
                        }


                    }

                    if (check != 0)
                    {
                        Console.WriteLine($"Girdiğiniz sayı({sayi}) asal değildir.");
                    }

                    else
                    {
                        Console.WriteLine($"Girdiğiniz sayı({sayi}) asaldır.");
                    }

                }
                else
                {
                    Console.WriteLine("Lütfen sadece 1'den büyük sayı girişi yapınız.");
                    goto DMP;
                }
            }
            catch (FormatException e)
            {

                Console.WriteLine("Lütfen sadece sayı girişi yapınız.");
                goto DMP;
            }
            catch
            {
                Console.WriteLine("Lütfen daha küçük bir sayı  Girişi Yapınız!(" + int.MaxValue + ")");
                goto DMP;
            }

        }
    }
}

