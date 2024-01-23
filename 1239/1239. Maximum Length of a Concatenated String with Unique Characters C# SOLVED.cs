public class Solution {
    private int result = 0;

    public int MaxLength(IList<string> arr) {
        // Filter out the strings with duplicate characters
        arr = arr.Where(a => a.Distinct().Count() == a.Length).ToList();
        
        Dfs(arr, "", 0);
        return result;
    }

    private void Dfs(IList<string> arr, string path, int idx) {
        result = Math.Max(result, path.Length);
        for (int i = idx; i < arr.Count; i++) {
            if (!path.Intersect(arr[i]).Any()) {
                Dfs(arr, path + arr[i], i + 1);
            }
        }
    }
}
