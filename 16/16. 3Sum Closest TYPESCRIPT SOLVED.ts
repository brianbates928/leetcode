function threeSumClosest(nums: number[], target: number): number {
    nums.sort((a, b) => a - b);
    let closestSum = nums[0] + nums[1] + nums[2];

    for (let i = 0; i < nums.length - 2; i++) {
        let lo = i + 1, hi = nums.length - 1;

        while (lo < hi) {
            let currentSum = nums[i] + nums[lo] + nums[hi];

            if (Math.abs(currentSum - target) < Math.abs(closestSum - target)) {
                closestSum = currentSum;
            }

            if (currentSum < target) {
                lo++;
            } else if (currentSum > target) {
                hi--;
            } else {
                return currentSum;
            }
        }
    }

    return closestSum;
}
