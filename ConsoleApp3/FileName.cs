using System.Collections.Generic;

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

public static class BinaryTree
{
    public static bool IsSortedByLevels(TreeNode root)
    {
        if (root == null)
            return true;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int prevVal = int.MinValue;

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            if (node.val < prevVal)
                return false;

            prevVal = node.val;
            if (node.left != null)
                queue.Enqueue(node.left);
            if (node.right != null)
                queue.Enqueue(node.right);
        }
        return true;
    }
}