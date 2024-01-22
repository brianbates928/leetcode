function findErrorNums(nums: number[]): number[] {
    let duplicate = -1;
    let missing = -1;
    for (let i = 0; i < nums.length; i++) {
        let index = Math.abs(nums[i]) - 1;
        if (nums[index] < 0) {
            duplicate = Math.abs(nums[i]);
        } else {
            nums[index] *= -1;
        }
    }
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] > 0) {
            missing = i + 1;
            break;
        }
    }
    return [duplicate, missing];
}
