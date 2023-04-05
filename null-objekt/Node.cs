namespace null_objekt;

public interface INode
{
    int treeSize(INode node);
}

public class Node : INode
{
    public INode LeftNode { get; set; }
    public INode RightNode { get; set; }

    public int treeSize(INode node)
    {
        return 1 + treeSize(LeftNode) + treeSize(RightNode);
    }
}

public class LeafNode : INode
{
    public int treeSize(INode node)
    {
        return 0;
    }
}