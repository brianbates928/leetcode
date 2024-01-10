public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var res = new List<IList<int>>();
        Array.Sort(candidates);
        DFS(candidates, target, 0, new List<int>(), res);
        return res;
    }

    private void DFS(int[] candidates, int target, int start, List<int> path, IList<IList<int>> res) {
        if (target < 0) return;
        if (target == 0) {
            res.Add(new List<int>(path));
            return;
        }
        for (int i = start; i < candidates.Length; i++) {
            path.Add(candidates[i]);
            DFS(candidates, target - candidates[i], i, path, res);
            path.RemoveAt(path.Count - 1);
        }
    }
}
