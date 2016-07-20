using System;
namespace Chapter1
{
    class UniqueChars
    {
        public static bool IsUnique(string phrase)
        {
            phrase = phrase.ToLower();
            Console.WriteLine("=======" + phrase);
            int[] abc = new int[27];
            for (int i = 0; i < phrase.Length; i++)
            {
                int value = (int)phrase[i];
                int pos = value - 96;
                // check for space
                if (value - 32 == 0)
                {
                    abc[0]++;
                    if (abc[0] > 1)
                    {
                        return false;
                    }
                    continue;
                }
                // check for letters
                if (pos > 0 && pos < 27)
                {
                    abc[pos]++;
                    if (abc[pos] > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void Main()
        {
            Console.WriteLine(IsUnique("Borrador"));
            Console.WriteLine(IsUnique("PIEZA"));
            Console.WriteLine(IsUnique("Es una frase"));
            Console.WriteLine(IsUnique("PUEDE serquesibrother"));
            Console.WriteLine(IsUnique("murcielago"));
        }

    }

}