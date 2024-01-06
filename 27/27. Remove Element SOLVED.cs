public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // First basic C# program
        // Initialize a counter for the number of elements not equal to val
        int count = 0;
        
        // Iterate over each element in the array
        for (int i = 0; i < nums.Length; i++) {
            // If the current element is not equal to val
            if (nums[i] != val) {
                // Assign the current element to the position of the count
                // remove by overwriting it
                nums[count] = nums[i];
                
                // Increment  count
                count++;
            }
        }
        
        // Return count/number of elements not equal to val
        return count;
    }
}
