class Solution(object):
    def findErrorNums(self, nums):
        """
        :type nums: List[int]
        :rtype: List[int]
        """
        duplicate = -1
        missing = -1
        for i in range(len(nums)):
            index = abs(nums[i]) - 1
            if nums[index] < 0:
                duplicate = abs(nums[i])
            else:
                nums[index] *= -1
        for i in range(len(nums)):
            if nums[i] > 0:
                missing = i + 1
                break
        return [duplicate, missing]
