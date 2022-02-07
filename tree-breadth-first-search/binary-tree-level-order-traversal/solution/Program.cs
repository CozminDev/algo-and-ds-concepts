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
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        //start at root and level 0 and recursevly call each node in the tree with level +1
        //list[level].Add(node.val)
        //return list;

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> results = new List<IList<int>>();
            PopulateList(root, 0, results);
            return results;
        }

        private void PopulateList(TreeNode root, int level, IList<IList<int>> results)
        {
            if (root == null)
                return;

            if (results.Count < level + 1)
                results.Add(new List<int>());

            results[level].Add(root.val);

            PopulateList(root.left, level + 1, results);
            PopulateList(root.right, level + 1, results);
        }
    }
}
