
//Definition for a binary tree node.
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

public class Program
{
    public static void Main()
    {
        TreeNode root = new TreeNode();
        root.val = 1;
        root.left = new TreeNode(2, null, new TreeNode(4));
        root.right = new TreeNode(3);

        //Console.WriteLine("hold on..." + root.val + " then " + root.left.val + " then " + root.left.left.val); 
        Console.WriteLine(Tree2str(root));
    }
    public static string Tree2str(TreeNode root)
    {
        //Solution: 1(2(4)())(3()())
        string solution = "";

        if (root == null)
        {
            solution = "";
            return solution;
        }
        solution = root.val.ToString();

        if ((root.left == null && root.right != null) || (root.left != null && root.right == null))
            solution += $"()";

        if (root.left != null)
            solution += $"({Tree2str(root.left)})";
        if (root.right != null)
            solution += $"({Tree2str(root.right)})";
        return solution;


    }
    public static bool HasChildren(TreeNode node) => (node.left != null && node.right != null);
}