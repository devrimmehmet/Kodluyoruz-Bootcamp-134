# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/pangrams/problem?isFullScreen=true)

![Soru Metni1]()

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


        public static string pangrams(string s)
        {
                var set =new HashSet<char>();
                foreach(var c in s.ToLower())
                {
                    if(char.IsLetter(c))
                    {
                        set.Add(c);
                    }
                }    
                return set.Count ==26 ? "pangram" :"not pangram";
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.   GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.pangrams(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
