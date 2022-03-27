![Soru](https://github.com/devrimmehmet/Kodluyoruz-Bootcamp-134/blob/master/HackerRank/1-solve-me-first/SolveMeFirst.png?raw=true)    

---    
ÇÖZÜM
---

    using System;
    using System.Collections.Generic;
    using System.IO;
    class Solution {

        static int solveMeFirst(int a, int b) { 
          int number1=a;
          int number2=b;
          int result=number1+number2;
          return result;

        }

        static void Main(String[] args) {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1,val2);
            Console.WriteLine(sum);
        }
    }      
