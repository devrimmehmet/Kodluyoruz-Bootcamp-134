# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/a-very-big-sum/problem)

![Soru Metni](https://github.com/devrimmehmet/Kodluyoruz-Bootcamp-134/blob/master/HackerRank/3-a-very-big-sum/a-very-big-sum.png?raw=true)

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

        

        public static long aVeryBigSum(List<long> ar)
        {
            long total=0;
            foreach(var item in ar)
            {
                total += item;
            }
            return total;
        }   

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = Result.aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }