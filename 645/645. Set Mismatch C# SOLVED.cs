public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int duplicate = -1, missing = -1;
        for (int i = 0; i < nums.Length; i++) {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] < 0)
                duplicate = Math.Abs(nums[i]);
            else
                nums[index] *= -1;
        }
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) {
                missing = i + 1;
                break;
            }
        }
        return new int[] {duplicate, missing};
    }
}
