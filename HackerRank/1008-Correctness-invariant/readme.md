# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/correctness-invariant/problem)

![Soru Metni1](https://github.com/devrimmehmet/Kodluyoruz-Bootcamp-134/blob/master/HackerRank/1008-Correctness-invariant/8-Correctness-invariant.png?raw=true)
![Soru Metni1](https://github.com/devrimmehmet/Kodluyoruz-Bootcamp-134/blob/master/HackerRank/1008-Correctness-invariant/8-Correctness-invariant-1.png?raw=true)
---
## ÇÖZÜM
---

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;


    class Solution { 
        public static void insertionSort (int[] A) { 
            var j = 0; 
            for (var i = 1; i < A.Length; i++) { 
                var value = A[i]; 
                j = i - 1; 
                while (j >= 0 && value < A[j]) { 
                    A[j + 1] = A[j];
                    j = j - 1; 
                } 
                A[j + 1] = value; 
            } 
            Console.WriteLine(string.Join(" ", A)); 
        }

        static void Main(string[] args) { 
            Console.ReadLine(); 
            int [] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            insertionSort(_ar); 
        }
    }

