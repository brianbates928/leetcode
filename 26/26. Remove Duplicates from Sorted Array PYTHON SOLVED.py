class Solution(object):
    def removeDuplicates(self, nums):
        # If the list is empty, return 0
        if not nums:
            return 0

        # Initialize the counter for unique elements
        k = 0

        # Iterate over the list starting from the second element
        for i in range(1, len(nums)):
            # If the current element is different from the previous one
            if nums[i] != nums[k]:
                # Increment the counter
                k += 1
                # Move the current element to the next position of the last unique element
                nums[k] = nums[i]

        # Return the number of unique elements
        return k + 1
