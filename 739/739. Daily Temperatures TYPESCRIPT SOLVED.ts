function dailyTemperatures(temperatures: number[]): number[] {
    let n: number = temperatures.length;
    let res: number[] = new Array(n).fill(0);
    let stack: number[] = [];
    for (let i = 0; i < n; ++i) {
        while (stack.length > 0 && temperatures[i] > temperatures[stack[stack.length - 1]]) {
            let j: number = stack.pop() as number;
            res[j] = i - j;
        }
        stack.push(i);
    }
    return res;
}
