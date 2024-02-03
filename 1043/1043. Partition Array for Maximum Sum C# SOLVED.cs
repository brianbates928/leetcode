public class Solution {
    public int MaxSumAfterPartitioning(int[] arr, int k) {
        int n = arr.Length;
        int[] dp = new int[n];
        for (int i = 0; i < n; i++) {
            int maxVal = arr[i];
            for (int j = 1; j <= k && i - j + 1 >= 0; j++) {
                maxVal = Math.Max(maxVal, arr[i - j + 1]);
                dp[i] = Math.Max(dp[i], (i >= j ? dp[i - j] : 0) + maxVal * j);
            }
        }
        return dp[n - 1];
    }
}
