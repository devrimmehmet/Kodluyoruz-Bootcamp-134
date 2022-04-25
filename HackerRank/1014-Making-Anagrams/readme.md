# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/making-anagrams/problem)

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

        public static int makingAnagrams(string s1, string s2)
        {
            var list1=s1.ToList();
            var list2=s2.ToList();
            int sum=list1.Count+list2.Count;
            int count=0;
            foreach(var c in list1)
                {
                if(list2.Contains(c))
                    {
                    list2.Remove(c);
                    count++;
                    }
                }
        return sum-count*2;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            int result = Result.makingAnagrams(s1, s2);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
