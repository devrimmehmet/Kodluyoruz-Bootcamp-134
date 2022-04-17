# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/funny-string/problem)

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
    
        public static string funnyString(string s)
        {
            var char1=s.ToCharArray();
            var char2=char1.Reverse().ToArray();
            
            for (int i=0;i<char1.Length-1;i++){
                if(Math.Abs(char1[i]-char1[1+i])==Math.Abs(char2[i]-char2   [i+1])){
                    continue;
                }else{
                    return "Not Funny";
                }
            }
            return "Funny";
        }
    
    }
    
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.   GetEnvironmentVariable("OUTPUT_PATH"), true);
    
            int q = Convert.ToInt32(Console.ReadLine().Trim());
    
            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();
    
                string result = Result.funnyString(s);
    
                textWriter.WriteLine(result);
            }
    
            textWriter.Flush();
            textWriter.Close();
        }
    }
    