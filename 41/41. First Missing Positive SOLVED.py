class Solution(object):
    def firstMissingPositive(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        n = len(nums)  # Store the length of the array

        # First loop: place each number in its correct index position (1 at index 0, 2 at index 1, etc.)
        for i in range(n):
            # While the number is within the valid range and not already in its correct position
            while 1 <= nums[i] <= n and nums[nums[i] - 1] != nums[i]:
                # Swap the number to its correct position
                nums[nums[i] - 1], nums[i] = nums[i], nums[nums[i] - 1]

        # Second loop: find the first place where the index and the number at that index don't match
        for i in range(n):
            if nums[i] != i + 1:
                # This is the first missing positive
                return i + 1

        # If all numbers are in their correct places, then the first missing positive is n + 1
        return n + 1
