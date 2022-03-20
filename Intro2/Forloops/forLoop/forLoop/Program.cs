using System;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] courses = {"Matematik","C#","Html","CSS","JavaScript","Sql"};

            
            //Console.WriteLine("Foreach");
            //Console.WriteLine("****************************************************************");
            //foreach (string course in courses) 
            //{ 
            //    Console.WriteLine(course);
            //}
            //Console.WriteLine("****************************************************************");
            //Console.WriteLine("****************************************************************");
            //Console.WriteLine("****************************************************************");


            //Console.WriteLine("For");
            //Console.WriteLine("****************************************************************");
            //for (int i = 0; i < courses.Length; i++)
            //{
            //    Console.WriteLine(courses[i]);
            //}
            //Console.WriteLine("****************************************************************");
            //Console.WriteLine("****************************************************************");
            //Console.WriteLine("****************************************************************");

            //int[] ages = { 42, 29, 26, 29, 29, 23 };
            //int ageTotal = 0;
            //for (int age = 0; age < ages.Length; age++)
            //{
            //    //ageTotal=ageTotal+ages[age];
            //    ageTotal+=ages[age];
                
            //}
            //Console.WriteLine($"Yaşların toplamı :{ageTotal}");
            //Console.WriteLine($"Yaşların Ortalaması :{ageTotal/ages.Length}");

            int[] numbers = { 36, 12, 26, 9, -4, 22, 8 };
            int minNumber = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
            {
                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i];
                }
                else
                { }
            }
            Console.WriteLine($"En Küçük Sayı : {minNumber}");
            int maxNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (maxNumber < numbers[i])
                {
                    maxNumber = numbers[i];
                }
                else
                { }
            }
            Console.WriteLine($"En Büyük Sayı : {maxNumber}");





        }
    }
}
