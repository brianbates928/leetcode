public class Solution {
    public int[] RearrangeArray(int[] nums) {
        List<int> positives = new List<int>();
        List<int> negatives = new List<int>();
        
        foreach (int num in nums) {
            if (num > 0) {
                positives.Add(num);
            } else {
                negatives.Add(num);
            }
        }
        int i = 0;
        while (i < nums.Length) {
            if (positives.Count > 0) {
                nums[i++] = positives[0];
                positives.RemoveAt(0);
            }
            if (negatives.Count > 0) {
                nums[i++] = negatives[0];
                negatives.RemoveAt(0);
            }
        }
        
        return nums;
    }
}
