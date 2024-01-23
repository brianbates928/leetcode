function maxLength(arr: string[]): number {
    let result = 0;

    function dfs(index: number, current: string) {
        // If the current string has duplicate characters, it's invalid
        if (new Set(current).size < current.length) {
            return;
        }

        result = Math.max(result, current.length);

        for (let i = index; i < arr.length; i++) {
            dfs(i + 1, current + arr[i]);
        }
    }

    dfs(0, "");

    return result;
}
