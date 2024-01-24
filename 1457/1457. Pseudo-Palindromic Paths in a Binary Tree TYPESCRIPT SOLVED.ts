/**
 * Definition for a binary tree node.
 * class TreeNode {
 *     val: number
 *     left: TreeNode | null
 *     right: TreeNode | null
 *     constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
 *         this.val = (val===undefined ? 0 : val)
 *         this.left = (left===undefined ? null : left)
 *         this.right = (right===undefined ? null : right)
 *     }
 * }
 */

function pseudoPalindromicPaths(root: TreeNode | null): number {
    return dfs(root, 0);
}

function dfs(node: TreeNode | null, path: number): number {
    if (node === null) {
        return 0;
    }

    // XOR operation to toggle the bit at the position of node.val
    path ^= (1 << node.val);

    let res = dfs(node.left, path) + dfs(node.right, path);

    // if it's a leaf node
    if (node.left === null && node.right === null) {
        // check if at most one bit in path is set to '1' (palindrome in binary representation)
        if ((path & (path - 1)) === 0) {
            res += 1;
        }
    }

    return res;
}
