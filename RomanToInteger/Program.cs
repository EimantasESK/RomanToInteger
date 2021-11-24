using System;

namespace RomanToInteger
{
    class Program
    {
        //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
        static void Main(string[] args)
        {
            static int RomanToInt(string s)
            {
                char[] num = s.ToCharArray();
                int sum = 0;
                int[] result = new int[50];
                for (int i = num.Length - 1; i >= 0; i--)
                {
                        if (num[i].ToString() == "I")
                        {
                            result[i] = 1;
                        }
                        if (num[i].ToString() == "V")
                        {
                            result[i] = 5;
                        }
                        if (num[i].ToString() == "X")
                        {
                            result[i] = 10;
                        }
                        if (num[i].ToString() == "L")
                        {
                            result[i] = 50;
                        }
                        if (num[i].ToString() == "C")
                        {
                            result[i] = 100;
                        }
                        if (num[i].ToString() == "D")
                        {
                            result[i] = 500;
                        }
                        if (num[i].ToString() == "M")
                        {
                            result[i] = 1000;
                        }
                }

                for (int i = 0; i < num.Length; i++)
                {
                    if (result[i] >= result[i + 1])
                    {
                        sum += result[i];
                    }
                    if (result[i] < result[i + 1])
                    {
                        sum -= result[i];
                    }
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
