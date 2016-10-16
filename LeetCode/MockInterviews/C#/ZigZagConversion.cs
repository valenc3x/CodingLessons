using System;

namespace MockInterviews
{
    class ZigZagConversion
    {

        public static string Convert(string s, int n)
        {
            string[] encode = new string[n];
            int si = 0;
            try
            {
                while (si <= s.Length) {
                    for (int i = 0; i < n; i++) {
                        encode[i] += s[si++];
                    }
                    for (int j = n-2; j > 0; j--) {
                        encode[j] += s[si++];
                    }
                }
            } catch (System.IndexOutOfRangeException) {
                // end of string
            }
            string result = "";
            for (int i = 0; i < encode.Length; i++)
            {
                result += encode[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(Convert("PAYPALISHIRING", 3));
            System.Console.WriteLine(Convert("", 1));
            System.Console.WriteLine(Convert("A", 1));
            System.Console.WriteLine(Convert("PAYPALISHIRING", 4));
            System.Console.WriteLine(Convert("ABCDE", 4));
        }


    }
}