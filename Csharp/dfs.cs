using System;
using System.Collections.Generic;

public class TreeNode
{
    public int Val { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int val)
    {
        Val = val;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    private TreeNode root;

    public BinaryTree(TreeNode node)
    {
        root = node;
    }

    // Recursive DFS traversal
    public void DFSRecursive(TreeNode node)
    {
        if (node != null)
        {
            Console.Write(node.Val + " ");
            DFSRecursive(node.Left);
            DFSRecursive(node.Right);
        }
    }

    // Iterative DFS traversal using a stack
    public void DFSIterative(TreeNode node)
    {
        if (node == null)
            return;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(node);

        while (stack.Count > 0)
        {
            TreeNode current = stack.Pop();
            Console.Write(current.Val + " ");

            // Push right child first so that left child is processed first (LIFO)
            if (current.Right != null)
                stack.Push(current.Right);

            if (current.Left != null)
                stack.Push(current.Left);
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Creating a binary tree
        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(2);
        root.Right = new TreeNode(3);
        root.Left.Left = new TreeNode(4);
        root.Left.Right = new TreeNode(5);
        root.Right.Left = new TreeNode(6);
        root.Right.Right = new TreeNode(7);

        BinaryTree tree = new BinaryTree(root);

        Console.WriteLine("Recursive DFS traversal:");
        tree.DFSRecursive(root);
        Console.WriteLine();

        Console.WriteLine("\nIterative DFS traversal:");
        tree.DFSIterative(root);
        Console.WriteLine();
    }
}