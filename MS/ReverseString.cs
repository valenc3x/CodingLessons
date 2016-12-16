using System;

public string ReverseString(string s){
    char[] c = new char[s.Length];
    for (int i = s.Length -1 ; i >=0; i--)
    {
        c[s.Length - 1 - i] = s[i];
    }
    return new string(c);
}

Console.WriteLine(ReverseString(""));
