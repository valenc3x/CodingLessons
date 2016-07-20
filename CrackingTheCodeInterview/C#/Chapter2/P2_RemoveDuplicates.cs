using System;
using Chapter2;

class RemoveDuplicates
{

    public static void Main()
    {
        SLinkedList sll = new SLinkedList();
        sll.Add(0);
        sll.Add(5);
        sll.Add(19);
        System.Console.WriteLine(sll.last.value);
        System.Console.WriteLine(sll.Size());
        sll.Add(44);
        sll.Add(190);
        System.Console.WriteLine(sll.last.value);
        sll.Add(5);
        sll.Add(19);
        System.Console.WriteLine(sll.last.value);
        sll.Add(44);
        sll.ShowList();
        System.Console.WriteLine(sll.Size());
        sll.RemoveDuplicates();
        sll.ShowList();
        System.Console.WriteLine(sll.last.value);
        System.Console.WriteLine(sll.Size());

    }
}
