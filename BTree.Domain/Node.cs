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
			InsertLeft(nodeValue);
		}
		else if (nodeValue > Value)
		{
			InsertRight(nodeValue);
		}
		
		// else already in the tree
	}

	private void InsertLeft(int nodeValue)
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

	private void InsertRight(int nodeValue)
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
}
