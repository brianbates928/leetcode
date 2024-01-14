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
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode groupPrev = dummy;
        
        while (true) {
            ListNode kth = GetKth(groupPrev, k);
            if (kth == null) {
                break;
            }
            ListNode groupNext = kth.next;
            
            // Reverse the group
            ListNode prev = kth.next, curr = groupPrev.next;
            while (curr != groupNext) {
                ListNode nextNode = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextNode;
            }
            
            // Connect with the previous group
            ListNode nextGroupPrev = groupPrev.next;
            groupPrev.next = prev;
            groupPrev = nextGroupPrev;
        }
        
        return dummy.next;
    }
    
    // Get the kth node after the node 'start' (0-indexed)
    private ListNode GetKth(ListNode start, int k) {
        ListNode curr = start;
        for (int i = 0; i < k; i++) {
            curr = curr.next;
            if (curr == null) {
                return null;
            }
        }
        return curr;
    }
}
