using System;

namespace MockInterviews
{
    class StringToInteger
    {
        public static int MyAtoi(string str)
        {
            str = str.Trim();
            if (str.Length == 0) {
                return 0;
            }
            bool hasSign = str[0] == '-' || str[0] == '+';
            bool isNegative = hasSign? str[0] == '-'? true: false : false;
            int number = 0;
            int i = hasSign ? 1: 0;
            for ( ; i<str.Length; i++) {
                char c = str[i];
                if (c >= '0' && c <= '9') {
                    int n = Convert.ToInt32(c) - '0';
                    try {
                        number = checked(number * 10);
                        number = checked(number + n);
                    } catch (System.OverflowException e) {
                        return isNegative? Int32.MinValue: Int32.MaxValue;
                    }
                }else{
                    return isNegative? number * -1: number;
                }
            }
            return isNegative? number * -1: number;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("   12"));
            Console.WriteLine(MyAtoi("12345  "));
            Console.WriteLine(MyAtoi("   12345  "));
            Console.WriteLine(MyAtoi("+12"));
            Console.WriteLine(MyAtoi("-12"));
            Console.WriteLine(MyAtoi("0"));
        }
    }
}
