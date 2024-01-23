function reverse(x: number): number {
    let rev = 0;
    if (x > 0x7FFFFFFF || x < -0x80000000) {
        return 0;
    }
    while (x !== 0) {
        rev = rev * 10 + x % 10;
        x = (x > 0) ? Math.floor(x / 10) : Math.ceil(x / 10);
        if (rev > 0x7FFFFFFF || rev < -0x80000000) {
            return 0;
        }
    }
    return rev;
}
