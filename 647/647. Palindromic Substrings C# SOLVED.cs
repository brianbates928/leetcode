public class Solution {
    public int CountSubstrings(string s) {
        int n = s.Length;
        bool[,] dp = new bool[n,n];
        int count = 0;

        for (int len = 1; len <= n; len++) {
            for (int i = 0; i <= n - len; i++) {
                int j = i + len - 1;
                if (s[i] == s[j]) {
                    dp[i,j] = len < 3 || dp[i+1,j-1];
                }
                if (dp[i,j]) {
                    count++;
                }
            }
        }
        return count;
    }
}
