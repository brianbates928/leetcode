public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // If the array is empty, return 0
        if (nums.Length == 0) return 0;

        // Initialize the counter for unique elements
        int k = 0;

        // Iterate over the array starting from the second element
        for (int i = 1; i < nums.Length; i++) {
            // If the current element is different from the previous one
            if (nums[i] != nums[k]) {
                // Increment the counter
                k++;
                // Move the current element to the next position of the last unique element
                nums[k] = nums[i];
            }
        }

        // Return the number of unique elements
        return k + 1;
    }

    }
