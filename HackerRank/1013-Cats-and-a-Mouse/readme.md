# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/cats-and-a-mouse/problem)

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
    
    class Solution {
    
        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z) {
        
          int range1=Math.Abs(z-x); 
          int range2=Math.Abs(z-y);
          if(range1>range2)
          {
          return "Cat B";
          }
          if(range2>range1)
          {
              return "Cat A";
          }
          
              return "Mouse C";
          
          
            
        }
    
        static void Main(string[] args) {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    
            int q = Convert.ToInt32(Console.ReadLine());
    
            for (int qItr = 0; qItr < q; qItr++) {
                string[] xyz = Console.ReadLine().Split(' ');
    
                int x = Convert.ToInt32(xyz[0]);
    
                int y = Convert.ToInt32(xyz[1]);
    
                int z = Convert.ToInt32(xyz[2]);
    
                string result = catAndMouse(x, y, z);
    
                textWriter.WriteLine(result);
            }
    
            textWriter.Flush();
            textWriter.Close();
        }
    }