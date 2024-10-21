namespace CSharp12.AdvancedPatternMatching;

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public static string SearchTree(TreeNode node)
    {
        return node switch
        {
            // Using let to capture the node value
            { Value: let value, Left: null, Right: null } => $"Leaf node with value {value}",
            { Left: { Value: let leftValue } } when leftValue > 0 => "Left child is positive",
            { Right: { Value: let rightValue } } when rightValue < 0 => "Right child is negative",
            _ => "Other node"
        };
    }

}
