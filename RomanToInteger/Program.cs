using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
        static void Main(string[] args)
        {
            static int RomanToInt(string s)
            {
                int sum = 0;

                Dictionary<char, int> number = new Dictionary<char, int>();
                number.Add('I', 1);
                number.Add('V', 5);
                number.Add('X', 10);
                number.Add('L', 50);
                number.Add('C', 100);
                number.Add('D', 500);
                number.Add('M', 1000);

                int sec = 0;

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (number[s[i]] >= sec)
                    {
                        sum += number[s[i]];
                    }
                    else
                        sum -= number[s[i]];

                    sec = number[s[i]];
                }

                return sum;
            }
            string test1 = "III"; //output: 3
            string test2 = "IV"; //output: 4
            string test3 = "IX"; //output: 9
            string test4 = "LVIII"; //output:58
            string test5 = "MCMXCIV"; //output:1994

            Console.WriteLine(RomanToInt(test1));
        }
    }
}
