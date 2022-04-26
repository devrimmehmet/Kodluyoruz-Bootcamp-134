# [Soruya Gitmek İçin Tıklayın](https://www.hackerrank.com/challenges/strong-password/problem)

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


    class Solution
    {
        public static void Main(string[] args)
        {
             var extraChars = 0;
            var digitOccured = false;
            var lowerCaseOccured = false;
            var upperCaseOccured = false;
            var specialCharsOccured = false;
            var desiredLength = 0;

            Console.ReadLine();
            var nextChar = Console.Read();


            while (nextChar != -1)
            {

                if (nextChar >= 48 && nextChar <= 57)
                    digitOccured = true;

                if (nextChar >= 97 && nextChar <= 122)
                    lowerCaseOccured = true;

                if (nextChar >= 65 && nextChar <= 90)
                    upperCaseOccured = true;


                if (nextChar == 33
                   || nextChar == 64
                   || nextChar == 94
                   || nextChar == 45
                   ) //!@^-
                    specialCharsOccured = true;

                if (nextChar >= 35 && nextChar <= 38) //#$%&
                    specialCharsOccured = true;


                if (nextChar >= 40 && nextChar <= 43) //()*+
                    specialCharsOccured = true;

                desiredLength++;
                if (digitOccured && lowerCaseOccured && upperCaseOccured && specialCharsOccured &&  desiredLength >= 6)
                    break;

                nextChar = Console.Read();
            }

            if (!digitOccured)
                extraChars++;

            if (!lowerCaseOccured)
                extraChars++;

            if (!upperCaseOccured)
                extraChars++;

            if (!specialCharsOccured)
                extraChars++;

            if (desiredLength + extraChars < 6)
                extraChars += 6 - extraChars - desiredLength;

            Console.WriteLine(extraChars);
        }
    }
