using System;

// Definition for singly-linked list.

class PartitionList {

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x) { val = x; }
    }

    static ListNode Partition(ListNode head, int x)
    {

        ListNode aux = head;

        ListNode lHead = new ListNode(-1);
        ListNode uHead = new ListNode(-1);
        ListNode l = new ListNode(0);
        ListNode u = new ListNode(0);

        lHead.next = l;
        uHead.next = u;

        while (aux != null) {
            if (aux.val < x) {
                l.next = new ListNode(aux.val);
                l = l.next;
            }else{
                u.next = new ListNode(aux.val);
                u = u.next;
            }
            aux = aux.next;
        }
        l.next = uHead.next.next;
        return lHead.next.next;
    }

    static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(4);
        ListNode node = head.next;
        node.next = new ListNode(3);
        node = node.next;
        node.next = new ListNode(2);
        node = node.next;
        node.next = new ListNode(5);
        node = node.next;
        node.next = new ListNode(2);
        node = node.next;

        ListNode result = Partition(head, 3);
        ListNode aux = result;

        while (aux != null) {
            System.Console.Write(aux.val +"->");
            aux = aux.next;
        }
    }
}
