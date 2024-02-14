function rearrangeArray(nums: number[]): number[] {
    let positives: number[] = nums.filter(num => num > 0);
    let negatives: number[] = nums.filter(num => num < 0);
    
    let result: number[] = [];
    while (positives.length > 0 || negatives.length > 0) {
        if (positives.length > 0) {
            result.push(positives.shift() as number);
        }
        if (negatives.length > 0) {
            result.push(negatives.shift() as number);
        }
    }
    
    return result;
};
