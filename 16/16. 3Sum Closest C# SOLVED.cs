public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        // Sort the array
        Array.Sort(nums);
        int closestSum = nums[0] + nums[1] + nums[2];
        // MinDiff holds the difference between the closestSum and the target
        // If closestSum is greater than target, subtract target from closestSum
        // If target is greater than closestSum, subtract closestSum from target
        // This gives us the minimum difference (minDiff) between closestSum and target
        int minDiff = closestSum - target > 0 ? closestSum - target : target - closestSum;

        // Iterate over the array
        for (int i = 0; i < nums.Length - 2; i++) {
            // Set two pointers: one at the next number, and one at the end of the array
            int lo = i + 1, hi = nums.Length - 1;

            // Move these pointers towards each other
            while (lo < hi) {
                // Calculate the sum of the three numbers
                int sum = nums[i] + nums[lo] + nums[hi];
                int diff = sum - target > 0 ? sum - target : target - sum;

                // If the difference between the sum and the target is less than the minimum difference Update the closestSum and the minimum difference
                if (diff < minDiff) {
                    closestSum = sum;
                    minDiff = diff;
                }

                // If the sum is less than target, move the left
                if (sum < target) {
                    lo++;
                } 
                // If the sum is more than  target, move the right pointer
                else if (sum > target) {
                    hi--;
                } 
                // If the sum is the target, return the sum
                else {
                    return sum;
                }
            }
        }
        return closestSum;
    }
}
