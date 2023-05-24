using System;

class Program
{
    static void Main()
    {
        // Create binary tree: 1, 3, 4, 6, 6, 7, 7, 8, 9
        TreeNode root1 = new TreeNode(1);
        root1.left = new TreeNode(3);
        root1.right = new TreeNode(4);
        root1.left.left = new TreeNode(6);
        root1.left.right = new TreeNode(6);
        root1.right.left = new TreeNode(7);
        root1.right.right = new TreeNode(7);
        root1.left.left.left = new TreeNode(8);
        root1.left.left.right = new TreeNode(9);
        Console.WriteLine("Expected: True, Actual: " + BinaryTree.IsSortedByLevels(root1));

        // Create binary tree: 1, 3, 2
        TreeNode root2 = new TreeNode(1);
        root2.left = new TreeNode(3);
        root2.right = new TreeNode(2);
        Console.WriteLine("Expected: False, Actual: " + BinaryTree.IsSortedByLevels(root2));

        // Create binary tree: 1
        TreeNode root3 = new TreeNode(1);
        Console.WriteLine("Expected: True, Actual: " + BinaryTree.IsSortedByLevels(root3));

        // Empty binary tree
        Console.WriteLine("Expected: True, Actual: " + BinaryTree.IsSortedByLevels(null));
    }
}
