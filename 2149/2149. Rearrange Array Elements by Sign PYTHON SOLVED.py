class Solution(object):
    def rearrangeArray(self, nums):
        """
        :type nums: List[int]
        :rtype: List[int]
        """
        pos = [num for num in nums if num > 0]
        neg = [num for num in nums if num < 0]
        results = []
        while pos or neg:
            if pos:
                results.append(pos.pop(0))
            if neg:
                results.append(neg.pop(0))
        return results
