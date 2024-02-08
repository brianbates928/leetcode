public class Solution {
    public int NumSquares(int n) {
        int[] dp = new int[n + 1];
        for (int i = 1; i <= n; i++) {
            dp[i] = i; // maximum is i because 1 is a perfect square
            for (int j = 1; j * j <= i; j++) {
                dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
            }
        }
        return dp[n];
    }
}
