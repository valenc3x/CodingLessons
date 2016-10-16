
// Definition for singly-linked list with a random pointer.
public class RandomListNode {
  public int label;
  public RandomListNode next, random;
  public RandomListNode(int x) { this.label = x; }
};

public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        RandomListNode traveler = head;
        RandomListNode copy = new RandomListNode(0);
        RandomListNode new_head = head;
        while(traveler != null)
        {
            // new data
            RandomListNode n_label = new RandomListNode(traveler.label);
            copy.label = n_label.label;

            if( traveler.next != null)
            {
                RandomListNode n_next = new RandomListNode(traveler.next.label);
                copy.next = n_next;
            }else{
                copy.next = null;
            }

            if( traveler.random != null)
            {
                RandomListNode n_random = new RandomListNode(traveler.random.label);
                copy.random = n_random;
            }else{
                copy.random = null;
            }

            // move forward
            traveler = traveler.next;
            copy = copy.next;

        }
       return new_head;
    }
}
