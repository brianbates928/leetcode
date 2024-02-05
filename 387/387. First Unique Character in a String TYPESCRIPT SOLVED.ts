function firstUniqChar(s: string): number {
    let counts = new Map<string, number>();
    for (let c of s) {
        if (counts.has(c)) {
            counts.set(c, counts.get(c)! + 1);
        } else {
            counts.set(c, 1);
        }
    }

    for (let i = 0; i < s.length; i++) {
        if (counts.get(s[i]) === 1) {
            return i;
        }
    }

    return -1;
};
