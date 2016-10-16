using System;
using System.Collections;

namespace Chapter2
{
    public class Node
    {
        public int value {get; set;}
        public Node next {get; set;}

        public Node(int v)
        {
            this.value = v;
            this.next = null;
        }
    }

    public class SLinkedList
    {
        public Node head;
        public Node last;
        private int size;

        public SLinkedList(){
            this.head = null;
            this.last = null;
            this.size = 0;
        }

        public SLinkedList(int first)
        {
            this.head = new Node(first);
            this.last = head;
            this.size = 1;
        }


        public Node Add(int v)
        {
            Node n = new Node(v);
            if(this.head == null)
            {
                this.head = n;
                this.last = this.head;
                this.size++;
                return this.head;
            }
            this.last.next = n;
            this.last = this.last.next;
            this.size++;
            return this.last;
        }

        public int Size()
        {
            return this.size;
        }

        public void RemoveDuplicates()
        {
            Hashtable dict<int, int> = new Hashtable<int, int>();
            Node aux = this.head;
            Node prev = null;
            while (aux != null){
                if (dict.ContainsKey(aux.value))
                {
                    prev.next = aux.next;
                    this.size--;
                } else {
                    dict.Add(aux.value, aux);
                    prev = aux;
                }
                aux = aux.next;
            }
            this.last = prev;
        }


        public void ShowList()
        {
            Node aux = this.head;
            string list = "SLL: " + aux.value;
            while (aux.next != null)
            {
                aux = aux.next;
                list += " -> " + aux.value;
            }
            System.Console.WriteLine(list);
        }
    }
}
