function minSteps(s: string, t: string): number {
    let sCount = new Array(26).fill(0);
    let tCount = new Array(26).fill(0);
    let steps = 0;

    for (let i = 0; i < s.length; i++) {
        sCount[s.charCodeAt(i) - 'a'.charCodeAt(0)]++;
        tCount[t.charCodeAt(i) - 'a'.charCodeAt(0)]++;
    }

    for (let i = 0; i < 26; i++) {
        if (tCount[i] < sCount[i]) {
            steps += sCount[i] - tCount[i];
        }
    }

    return steps;
}
