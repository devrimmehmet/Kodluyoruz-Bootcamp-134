using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose traffic Light (R/G/Y)");

            string choosing=Console.ReadLine();
            if (choosing =="R") 
            {
                Console.WriteLine("Dur - Stop!");
            }else if (choosing == "Y") 
            {
                Console.WriteLine("Dikkat - Warning");
            }else if (choosing == "G") 
            {
                Console.WriteLine("Geç - Pass");
            }
            else { Console.WriteLine("Hatalı Seçim - Wrong Choosing ..."); 
            }


            switch (choosing)
            {
                case "R":
                    Console.WriteLine("Dur - Stop!");
                    break;
                case "Y":
                    Console.WriteLine("Dikkat - Warning");
                    break;
                case "G":
                    Console.WriteLine("Geç - Pass");
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim - Wrong Choosing ...");
                    break;
            }

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("Hafta Sonu");
                    break;
                
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hafta İçi");
                    break;               
                
                default:
                    break;
            }

        }
    }
}
