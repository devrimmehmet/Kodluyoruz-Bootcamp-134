using System;

namespace serbestdusme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Yerçekimli ortamda serbest düşme yapan bir cismin istenilen saniyedeki hızını bulan formül.");
                Console.WriteLine("****************************************************************************");
                Console.Write("Lütfen Hava Sürtünme Katsayısını Giriniz.");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Lütfen Yerçekimini (m)/(s*s) giriniz");
                double g = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Lütfen cismin kütlesini giriniz(kg)");
                double m = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Cismin Kaçıncı saniyedeki hızını merak ediyorsunuz?");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("****************************************************************************");
                double result = (((g * m) / c) * (1 - (Math.Exp((c / m) * t * (-1)))));
                Console.WriteLine("Sonuç : " + result+"m/s");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Lütfen ilgili değerlere sayısal değer yazınız.");
                Console.WriteLine(e);
            }
        }
    }
}
