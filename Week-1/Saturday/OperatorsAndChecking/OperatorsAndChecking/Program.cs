using System;

namespace OperatorsAndChecking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3 + 5;
            string newWorld = "Bilgi"+"sayar";
            string newWorld2 = "Bootcamp" + 134;
            Console.WriteLine(newWorld2);
            Console.WriteLine(x.ToString());

            byte bigNumber = 254;
            byte smallNumber = 2;
            
            try
            {
                checked
                {
                    byte total = (byte)(bigNumber + smallNumber); // casting 
                    Console.WriteLine(total.ToString());    //hata vermesini istiyorsak checkedi kullanmalıyız
                }//hatayıda belirtmek için try catchin icine alıyoruz.
            }
            catch (System.OverflowException ex)
            {

                Console.WriteLine("Total value cannet cast to byte data type");
            }

           

            try
            {
                Console.WriteLine("Number1 is:");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number2 is:");
                int number2 = Convert.ToInt32(Console.ReadLine());
                int division = number1 / number2;
                Console.WriteLine($"Result {division}"); 
            }
            catch (FormatException)
            {

                Console.WriteLine("Please just give digits");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Number 2 cannot be 0.");
            }
        }
    }
}
