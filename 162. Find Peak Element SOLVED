class Solution(object):
    def findPeakElement(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        n = len(nums)
        if n==1 or n==0:
            return 0
        if nums[0]>nums[1]:
            return 0
        if n==2:
            if nums[0]>nums[1]:
                return 0
            else:
                return 1
        if nums[n-1]>nums[n-2]:
            return n-1
        for i in range (1, n-1):
                if nums[i-1] < nums[i] > nums[i+1]:
                    return i
        return 0
