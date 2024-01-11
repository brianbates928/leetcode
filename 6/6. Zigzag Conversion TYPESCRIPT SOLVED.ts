function convert(s: string, numRows: number): string {
    if (numRows === 1 || numRows >= s.length) {
        return s;
    }

    let arr: string[] = Array(numRows).fill('');
    let index = 0, step = 1;

    for (let char of s) {
        arr[index] += char;
        if (index === 0) {
            step = 1;
        } else if (index === numRows - 1) {
            step = -1;
        }
        index += step;
    }

    return arr.join('');
}
