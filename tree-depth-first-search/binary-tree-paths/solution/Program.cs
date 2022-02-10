using System;
using System.Collections.Generic;

namespace solution
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3));
            Solution sol = new Solution();
            sol.BinaryTreePaths(root);
        }
    }

    public class Solution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> paths = new List<string>();
            GetBinaryTreePaths(root, "", paths);
            return paths;
        }

        private void GetBinaryTreePaths(TreeNode root, string path, IList<string> paths)
        {
            if (root == null)
                return;

            if(root.left == null && root.right == null)
            {
                path = path + root.val;
                paths.Add(path);
                return;
            }

            GetBinaryTreePaths(root.left, path + root.val + "->", paths);
            GetBinaryTreePaths(root.right, path + root.val + "->", paths);
        }
    }
}
