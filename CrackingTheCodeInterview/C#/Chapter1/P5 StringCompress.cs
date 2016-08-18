using System;

namespace Chapter1
{
    public class CompressWords{

        public static string StringCompress(string word){
            string compressed = "";
            int count = 0;
            char current = '\0';
            for (int i = 0; i < word.Length; i++)
            {
                if (current != word[i])
                {
                    count = 0;
                    current = word[i];
                }
                count++;
                if (i <= word.Length-1 && current != word[i+1])
                {
                    compressed += string.Concat(current, count);
                }
            }
            if (compressed.Length > word.Length)
            {
                return word;
            }else{
                return compressed;
            }
        }

        public static void Main(){
            System.Console.WriteLine(StringCompress("a"));
            System.Console.WriteLine(StringCompress("abbbb"));
            System.Console.WriteLine(StringCompress("aaabbbcccaab"));
            System.Console.WriteLine(StringCompress("abcde"));
        }

    }
}
