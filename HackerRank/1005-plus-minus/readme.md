# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/plus-minus/problem)

![Soru Metni1](https://github.com/devrimmehmet/Kodluyoruz-Bootcamp-134/blob/master/HackerRank/5-plus-minus/plus-minus1.png?raw=true)
![Soru Metni2](https://github.com/devrimmehmet/Kodluyoruz-Bootcamp-134/blob/master/HackerRank/5-plus-minus/plus-minus2.png)
---
## ÇÖZÜM
---

    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            double pozitiveItemCount=0;
            double pozitifResult=0;
            double negativeItemCount=0;
            double negativeResult=0;
            double zeroItemCount=0;
            double zeroResult=0;
            foreach(var item in arr)
            {
               if(item<0)
               {
                   negativeItemCount=negativeItemCount+1;
               }else if(item>0)
               {
                   pozitiveItemCount=pozitiveItemCount+1;

               } else{
                   zeroItemCount=zeroItemCount+1;
               }
               }
               negativeResult=negativeItemCount/(arr.Count());
               pozitifResult=pozitiveItemCount/(arr.Count());
               zeroResult=zeroItemCount/((arr.Count()));
               Console.WriteLine(Math.Round(pozitifResult, 6));
               Console.WriteLine(Math.Round(negativeResult, 6));
               Console.WriteLine(Math.Round(zeroResult, 6));

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp =>  Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
