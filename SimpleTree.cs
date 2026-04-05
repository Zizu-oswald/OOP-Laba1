public class TreeNode
{
    public string Value { get; set; }
    public List<TreeNode> Children { get; set; }

    public TreeNode(string value)
    {
        Value = value;
        Children = new List<TreeNode>();
    }

    public void AddChild(TreeNode child)
    {
        Children.Add(child);
    }

    public void PrintAllValues()
    {
        Console.WriteLine(Value);

        if (Children.Count == 0)
        {
            return;
        }

        foreach (TreeNode child in Children)
        {
            child.PrintAllValues();
        }
    }
}

