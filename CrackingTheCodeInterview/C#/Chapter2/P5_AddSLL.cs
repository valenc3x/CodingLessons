using System;
using Chapter2;

class AddSLL
{
    public static SLinkedList AddLL(SLinkedList num1, SLinkedList num2)
    {
        int tenth = 1;
        int n1 = 0;
        int n2 = 0;
        Node aux = num1.head;
        while (aux != null)
        {
            n1 += aux.value * tenth;
            tenth *= 10;
            aux = aux.next;
        }
        tenth = 1;
        aux = num2.head;
        while (aux != null)
        {
            n2 += aux.value * tenth;
            tenth *= 10;
            aux = aux.next;
        }

        int result = n1 + n2;
        System.Console.WriteLine(result);
        SLinkedList final = new SLinkedList(0);
        int n = result % 10;
        final.head.value = n;
        result /= 10;
        while (result > 0)
        {
            n = result % 10;
            result /= 10;
            final.Add(n);
        }
        return final;

    }
    static int Main(string[] args)
    {
        SLinkedList num1 = new SLinkedList(7);
        num1.Add(1);
        num1.Add(0);
        SLinkedList num2 = new SLinkedList(5);
        num2.Add(1);
        num2.Add(0);
        SLinkedList final = AddLL(num1, num2);
        System.Console.WriteLine("Final result");
        final.ShowList();
        return 0;
    }
}