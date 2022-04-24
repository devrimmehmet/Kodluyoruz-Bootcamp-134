# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/time-conversion/problem?isFullScreen=true)

![Soru Metni1](https://github.com/devrimmehmet/Kodluyoruz-Bootcamp-134/blob/master/HackerRank/1007-time-conversion/time-conversion.png?raw=true)

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
    using System.Globalization;
    
    class Result
    {
    
    
    
        public static string timeConversion(string s)
        {
            var dt =DateTime.ParseExact(s,"hh:mm:sstt", CultureInfo.InvariantCulture);
            return $"{dt:HH:mm:ss}";
                 
            
        }
    
    }
    
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);
    
            string s = Console.ReadLine();
    
            string result = Result.timeConversion(s);
    
            textWriter.WriteLine(result);
    
            textWriter.Flush();
            textWriter.Close();
        }
    }
