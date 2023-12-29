class Solution(object):
    def mergeTwoLists(self, list1, list2):
        """
        :type list1: Optional[ListNode]
        :type list2: Optional[ListNode]
        :rtype: Optional[ListNode]
        """
        # Create a dummy node to act as the head of the merged list
        dummy = tail = ListNode(-1)

        # While both lists have nodes left, compare their values and add the smaller one to the merged list
        while list1 and list2:
            if list1.val < list2.val:
                tail.next, list1 = list1, list1.next
            else:
                tail.next, list2 = list2, list2.next
            tail = tail.next

        # If there are nodes left in either list, add them to the merged list
        tail.next = list1 or list2

        # Return the merged list, excluding the dummy node at the start
        return dummy.next
