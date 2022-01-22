/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head ==null) return head;
        var movingHead = head;
        while(movingHead.next!=null)
        {
            if(movingHead.val ==movingHead.next.val)
              {
                  movingHead.next = movingHead.next.next;
              }
             else
               {
                   movingHead = movingHead.next;
               }
         }
         return head;
        
    }
}