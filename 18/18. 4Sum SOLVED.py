class Solution(object):
    def fourSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[List[int]]
        """
        nums.sort()
        results = []
        # Iterate over the array, with the first pointer 'i'
        for i in range(len(nums) - 3):
            # Skip over duplicate elements
            if i > 0 and nums[i] == nums[i - 1]:
                continue
            # Iterate over the array, with the second pointer 'j'
            for j in range(i + 1, len(nums) - 2):
                # Skip over duplicate elements
                if j > i + 1 and nums[j] == nums[j - 1]:
                    continue
                # Initialize two pointers, 'l' and 'r', to the remaining part of the array
                l, r = j + 1, len(nums) - 1
                # While the left and right dont meet
                while l < r:
                    # Calculate the sum 
                    s = nums[i] + nums[j] + nums[l] + nums[r]
                    # If find target
                    if s == target:
                        # Add the quadruplet to the results
                        results.append([nums[i], nums[j], nums[l], nums[r]])
                        # Skip over duplicate elements
                        while l < r and nums[l] == nums[l + 1]:
                            l += 1
                        while l < r and nums[r] == nums[r - 1]:
                            r -= 1
                        # Move both pointers towards the center
                        l += 1
                        r -= 1
                    # If the sum is less than target, move the left pointer
                    elif s < target:
                        l += 1
                    # If the sum is greater than target, move the right pointer
                    else:
                        r -= 1
        return results
