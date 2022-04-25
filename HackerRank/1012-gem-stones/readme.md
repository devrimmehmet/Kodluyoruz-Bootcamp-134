# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/gem-stones/problem)

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
    
        public static int gemstones(List<string> arr)
        {
            int counter=0;
            int result=0;
            var mydistinc =arr[0].Distinct().ToArray();
        
            for(int i=0;i<mydistinc.Length;i++)
            {
                for(int j=1;j<arr.Count;j++)
                {
                    
                    if(arr[j].Contains(mydistinc[i]))
                    {
                        counter++;
                    }
                    
                }
                
                if(counter==arr.Count-1)
                {
                    result++;
                    counter=0;
                }
                counter=0;
            }
            return result;
    
        }
    
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    
            int n = Convert.ToInt32(Console.ReadLine().Trim());
    
            List<string> arr = new List<string>();
    
            for (int i = 0; i < n; i++)
            {
                string arrItem = Console.ReadLine();
                arr.Add(arrItem);
            }
    
            int result = Result.gemstones(arr);
    
            textWriter.WriteLine(result);
    
            textWriter.Flush();
            textWriter.Close();
        }
    }
    }