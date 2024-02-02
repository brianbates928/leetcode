public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);
        List<int[]> result = new List<int[]>();
        for (int i = 0; i < nums.Length; i += 3) {
            if (nums[i + 2] - nums[i] <= k) {
                result.Add(new int[] { nums[i], nums[i + 1], nums[i + 2] });
            } else {
                return new int[0][];
            }
        }
        return result.ToArray();
    }
}
