namespace BTree.Domain;

public interface IStrategy
{
    public void Execute(Node node);
}
