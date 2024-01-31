function findSubstring(s: string, words: string[]): number[] {
    let res: number[] = [];
    if (!s || s.length === 0 || !words || words.length === 0) return res;
    let len_word: number = words[0].length;
    let word_map: { [key: string]: number } = {};
    for (let word of words) {
        word_map[word] = (word_map[word] || 0) + 1;
    }
    for (let i = 0; i < len_word; i++) {
        let start: number = i;
        let count: number = 0;
        let seen: { [key: string]: number } = {};
        for (let j = i; j <= s.length - len_word; j += len_word) {
            let sub_s: string = s.slice(j, j + len_word);
            if (word_map[sub_s] !== undefined) {
                seen[sub_s] = (seen[sub_s] || 0) + 1;
                if (seen[sub_s] <= word_map[sub_s]) count++;
                while (count === words.length) {
                    let start_s: string = s.slice(start, start + len_word);
                    if (seen[start_s] <= word_map[start_s]) count--;
                    seen[start_s]--;
                    if (j - start === len_word * (words.length - 1)) res.push(start);
                    start += len_word;
                }
            } else {
                seen = {};
                count = 0;
                start = j + len_word;
            }
        }
    }
    return res;
}
