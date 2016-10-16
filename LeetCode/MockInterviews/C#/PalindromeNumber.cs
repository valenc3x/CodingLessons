using System;

namespace MockInterviews
{
    public class PalindromeNumber
    {

        public static bool IsPalindrome(int x) {
            int number = 0;
            int res = 0;
            int limit = x;
            while (limit > 0) {
                res = limit % 10;
                limit -= res;
                limit /= 10;
                number *= 10;
                number += res;
            }
            return number == x;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(123321));
            Console.WriteLine(IsPalindrome(1234321));
            Console.WriteLine(IsPalindrome(123456));
            Console.WriteLine(IsPalindrome(123421));
        }
    }
}
