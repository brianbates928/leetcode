public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        // Sort the array for easy comparing
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();

        // Iterate over the array
        for (int i = 0; i < nums.Length - 2; i++) {
            // Skip duplicate 
            if (i == 0 || (i > 0 && nums[i] != nums[i-1])) {
                // Set two pointers: one at the next number, and one at the end of the array
                int lo = i + 1;
                int hi = nums.Length - 1;
                int sum = 0 - nums[i]; //negative where you are in the loop

                // Move these pointers towards each other
                while (lo < hi) {
                    // Check if the sum of the three numbers is zero
                    if (nums[lo] + nums[hi] == sum) {
                        // If it is, add them to the result list
                        result.Add(new List<int>() {nums[i], nums[lo], nums[hi]});
                        // Skip duplicate numbers when a valid triplet is found
                        while (lo < hi && nums[lo] == nums[lo+1]) lo++;
                        while (lo < hi && nums[hi] == nums[hi-1]) hi--;
                        lo++; hi--;
                    } else if (nums[lo] + nums[hi] < sum) {
                        // If the sum is less than zero, move the left pointer to the right
                        lo++;
                    } else {
                        // If the sum is more than zero, move the right pointer to the left
                        hi--;
                    }
                }
            }
        }
        // Return the result
        return result;
    }
}
