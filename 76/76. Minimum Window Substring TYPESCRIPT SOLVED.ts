function minWindow(s: string, t: string): string {
    if (!s || !t) {
        return "";
    }

    let tFrequency: number[] = Array(128).fill(0);
    for (let c of t) {
        tFrequency[c.charCodeAt(0)]++;
    }

    let required: number = t.length;
    let left: number = 0, right: number = 0;
    let minLen: number = Number.MAX_SAFE_INTEGER;
    let minWindow: string = "";

    while (right < s.length) {
        if (tFrequency[s.charCodeAt(right)] > 0) {
            required--;
        }
        tFrequency[s.charCodeAt(right)]--;

        while (required === 0) {
            if (right - left + 1 < minLen) {
                minLen = right - left + 1;
                minWindow = s.substring(left, right + 1);
            }

            tFrequency[s.charCodeAt(left)]++;
            if (tFrequency[s.charCodeAt(left)] > 0) {
                required++;
            }
            left++;
        }
        right++;
    }

    return minLen === Number.MAX_SAFE_INTEGER ? "" : minWindow;
}
