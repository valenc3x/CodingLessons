using System;
using Chapter2;

class Palindrome
{
    public static bool IsPalindrome(SLinkedList list)
    {
        Node runner = list.head;
        Node aux = list.head;
        int size = 1;
        while (runner != null && runner.next != null)
        {
            aux = aux.next;
            runner = runner.next?.next;
            size++;
        }
        int[] palindrome = new int [size];
        runner = list.head;
        System.Console.WriteLine("s: " + size);
        System.Console.WriteLine("a: " + aux.value);
        System.Console.WriteLine("an: " + aux.next.value);
        for (int i = 0; i < palindrome.Length; i++)
        {
            if (runner == aux)
            {
                break;
            }
            palindrome[i] = runner.value;
            System.Console.WriteLine(palindrome[i]);
            runner = runner.next;
        }
        System.Console.WriteLine("next value: " + aux.next.value);
        for (int i = palindrome.Length -1; i >= 0; i--)
        {
            System.Console.WriteLine("index: " + i);
            System.Console.WriteLine("p: " + palindrome[i]);
            System.Console.WriteLine("l: " + aux.value);
            if (palindrome[i] != aux.value)
            {
                return false;
            }
            aux = aux.next;
        }
        return true;
    }

    public static void Main()
    {

        SLinkedList palindrome = new SLinkedList();
        palindrome.Add(1);
        palindrome.Add(0);
        palindrome.Add(2);
        palindrome.Add(2);
        palindrome.Add(0);
        palindrome.Add(1);
        palindrome.ShowList();
        System.Console.WriteLine(IsPalindrome(palindrome));
    }
}