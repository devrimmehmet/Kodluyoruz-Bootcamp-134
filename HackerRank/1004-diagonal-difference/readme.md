# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/diagonal-difference/problem)

![Soru Metni1](https://github.com/devrimmehmet/Kodluyoruz-Bootcamp-134/blob/master/HackerRank/4-diagonal-difference/Diagonal-Difference1.png?raw=true)
![Soru Metni2](https://github.com/devrimmehmet/Kodluyoruz-Bootcamp-134/blob/master/HackerRank/4-diagonal-difference/Diagonal-Difference2.png?raw=true)
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



        public static int diagonalDifference(List<List<int>> arr)
        {
           var n= arr.Count;
           var solve1=0;
           var solve2=0;
           var solve=0;
           for(int i=0;i<n;i++)
           {
               for(int j=0;j<n;j++)
               {
                   if(i==j)
                   {
                       solve1=solve1+arr[i][j];
                   }
                   if(i+j==n-1)
                   {
                       solve2=solve2+arr[i][j];
                   }

               }
           }
           solve=solve1-solve2;
           solve=Math.Abs(solve);
           return solve;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
   