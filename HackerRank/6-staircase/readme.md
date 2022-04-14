# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/staircase/problem)

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
    
    
    
        public static void staircase(int n)
        {
                for(int i=0;i<n;i++)
                {
                    for(int j=0;j<n;j++)
                    {
                        Console.Write(" ");
                    }
                    
                    Console.Write("#");
                }
        }
    
    }
    
    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
    
            Result.staircase(n);
        }
    }
