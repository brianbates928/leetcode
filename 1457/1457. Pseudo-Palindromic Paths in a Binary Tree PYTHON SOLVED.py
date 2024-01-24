# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def pseudoPalindromicPaths (self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        def dfs(node, path):
            if node is None:
                return 0
            
            # XOR operation to toggle the bit at the position of node.val
            path ^= (1 << node.val)
            
            res = dfs(node.left, path) + dfs(node.right, path)
            
            # if it's a leaf node
            if node.left is None and node.right is None:
                # check if at most one bit in path is set to '1' (palindrome in binary representation)
                if path & (path - 1) == 0:
                    res += 1
            
            return res
        
        return dfs(root, 0)
