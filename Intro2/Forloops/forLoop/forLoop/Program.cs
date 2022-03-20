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

            int[] ages = { 42, 29, 26, 29, 29, 23 };
            int ageTotal = 0;
            for (int age = 0; age < ages.Length; age++)
            {
                ageTotal=ageTotal+ages[age];
                
            }
            Console.WriteLine(ageTotal);
        }
    }
}
