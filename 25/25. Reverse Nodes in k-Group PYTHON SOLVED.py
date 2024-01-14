class Solution(object):
    def reverseKGroup(self, head, k):
        """
        :type head: ListNode
        :type k: int
        :rtype: ListNode
        """
        # Create a dummy node that points to the head
        dummy = ListNode(0)
        dummy.next = head
        groupPrev = dummy
        
        while True:
            kth = self.getKth(groupPrev, k)
            if kth is None:
                break
            groupNext = kth.next
            
            # Reverse the group
            prev, curr = kth.next, groupPrev.next
            while curr != groupNext:
                nextNode = curr.next
                curr.next = prev
                prev = curr
                curr = nextNode
            
            # Connect with the previous group
            nextGroupPrev = groupPrev.next
            groupPrev.next = prev
            groupPrev = nextGroupPrev
        
        return dummy.next
    
    # Get the kth node after the node 'start' (0-indexed)
    def getKth(self, start, k):
        curr = start
        for _ in range(k):
            curr = curr.next
            if curr is None:
                return None
        return curr
