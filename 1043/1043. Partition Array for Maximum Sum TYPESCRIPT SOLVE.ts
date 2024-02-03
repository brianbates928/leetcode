function maxSumAfterPartitioning(arr: number[], k: number): number {
    let n = arr.length;
    let dp: number[] = new Array(n).fill(0);
    for (let i = 0; i < n; i++) {
        let maxVal = arr[i];
        for (let j = 1; j <= k && i - j + 1 >= 0; j++) {
            maxVal = Math.max(maxVal, arr[i - j + 1]);
            dp[i] = Math.max(dp[i], (i >= j ? dp[i - j] : 0) + maxVal * j);
        }
    }
    return dp[n - 1];
};
