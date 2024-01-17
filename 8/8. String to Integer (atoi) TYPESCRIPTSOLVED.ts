function myAtoi(s: string): number {
    let i = 0;
    let sign = 1;
    let result = 0;
    const n = s.length;
    const INT_MAX = 2147483647;
    const INT_MIN = -2147483648;

    // Ignore leading whitespaces
    while (i < n && s[i] === ' ') {
        i++;
    }

    // Check for optional sign
    if (i < n && (s[i] === '+' || s[i] === '-')) {
        sign = (s[i++] === '-') ? -1 : 1;
    }

    // Read in next the characters until the next non-digit character
    while (i < n && s[i] >= '0' && s[i] <= '9') {
        // Check for overflow
        if (result > (INT_MAX - (s[i].charCodeAt(0) - '0'.charCodeAt(0))) / 10) {
            return (sign === 1) ? INT_MAX : INT_MIN;
        }
        result = result * 10 + (s[i++].charCodeAt(0) - '0'.charCodeAt(0));
    }

    return result * sign;
}
