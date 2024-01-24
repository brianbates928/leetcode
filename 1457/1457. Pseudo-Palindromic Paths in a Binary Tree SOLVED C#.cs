public class Solution {
    public int PseudoPalindromicPaths(TreeNode root) {
        return Dfs(root, 0);
    }

    private int Dfs(TreeNode node, int path) {
        if (node == null) {
            return 0;
        }

        // XOR operation to toggle the bit at the position of node.val
        path ^= (1 << node.val);

        int res = Dfs(node.left, path) + Dfs(node.right, path);

        // if it's a leaf node
        if (node.left == null && node.right == null) {
            // check if at most one bit in path is set to '1' (palindrome in binary representation)
            if ((path & (path - 1)) == 0) {
                res += 1;
            }
        }

        return res;
    }
}
