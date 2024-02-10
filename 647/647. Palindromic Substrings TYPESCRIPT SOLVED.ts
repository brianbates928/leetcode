function countSubstrings(s: string): number {
    let n = s.length;
    let dp: boolean[][] = Array(n).fill(false).map(() => Array(n).fill(false));
    let count = 0;

    for (let len = 1; len <= n; len++) {
        for (let i = 0; i <= n - len; i++) {
            let j = i + len - 1;
            if (s.charAt(i) === s.charAt(j)) {
                dp[i][j] = len < 3 || dp[i+1][j-1];
            }
            if (dp[i][j]) {
                count++;
            }
        }
    }
    return count;
}
