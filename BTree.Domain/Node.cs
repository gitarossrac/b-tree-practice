namespace BTree.Domain;

public class Node
{
	public Node Left { get; set; }
	
	public Node Right { get; set; }
	
	public int Value { get; private init; }
	
	public Node(int @value)
	{
		Value = @value;
	}
	
	public bool IsLeaf => Left == null && Right == null;

	public void Insert(int nodeValue)
	{
		if (nodeValue < Value)
		{
			if (Left != null)
			{
				Left.Insert(nodeValue);
			}
			else
			{
				Left = new Node(nodeValue);
			}
		}
		else if (nodeValue > Value)
		{
			if (Right != null)
			{
				Right.Insert(nodeValue);
			}
			else
			{
				Right = new Node(nodeValue);
			}
		}
		
		// else already in the tree
	}
}
