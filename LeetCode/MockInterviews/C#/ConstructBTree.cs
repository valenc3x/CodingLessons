using System;
using System.Collections;

// Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}
public class Solution {

    public static void PrintArray(int[] array){
        foreach (int n in array)
        {
            Console.Write(n);
        }
        Console.WriteLine();
    }

    public static TreeNode BuildTree(int[] preorder, int[] inorder) {
        Console.WriteLine("====" + preorder[0]);
        int current = preorder[0];
        TreeNode root = new TreeNode(current);
        int i;
        Console.WriteLine("inorder.Length");
        Console.WriteLine(inorder.Length);
        if (inorder.Length <= 1)
        {
            return null;
        }
        for (i=0; i<inorder.Length; i++)
        {
            if (inorder[i] == current)
            {
                break;
            }
        }

        int[] new_preorder = new int[preorder.Length-1];
        Array.Copy(preorder, 1, new_preorder, 0, preorder.Length-1);
        Console.Write("np ->");
        PrintArray(new_preorder);

        int[] left_inorder = new int[i];
        Array.Copy(inorder, 0, left_inorder, 0, i);
        Console.Write("li ->");
        PrintArray(left_inorder);

        int[] right_inorder = new int[inorder.Length-1-i];
        Array.Copy(inorder, i+1, right_inorder, 0, inorder.Length-i-1);
        Console.Write("ri ->");
        PrintArray(right_inorder);

        root.left = BuildTree(new_preorder, left_inorder);
        root.right = BuildTree(new_preorder, right_inorder);

        return root;
    }

    public static void Main(){
        TreeNode tree = BuildTree(new int[]{4, 2 ,5 , 1, 6, 3}, new int[]{1, 2, 4, 5, 3, 6});
    }
}
