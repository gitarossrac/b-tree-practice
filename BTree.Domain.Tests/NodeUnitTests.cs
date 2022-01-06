using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BTree.Domain.Tests;

[TestClass]
public class NodeUnitTests
{
    [TestMethod]
    public void Node_ShouldStoreValue_PassedIntoConstructor()
    {
        var node = new Node(4);

        node.Value.Should().Be(4);
    }
}