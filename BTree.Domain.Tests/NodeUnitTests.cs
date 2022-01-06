using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BTree.Domain.Tests;

[TestClass]
public class NodeUnitTests
{
    [TestMethod]
    public void Value_ShouldBeValuePassedIntoConstructor()
    {
        // Arrange
        var expectedValue = 4;
        var node = new Node(expectedValue);

        // Act
        var actualValue = node.Value;

        // Assert
        actualValue.Should().Be(expectedValue);
    }

    [TestMethod]
    public void Node_ShouldBeLeafNode_WhenHasNoChildren()
    {
        // Arrange
        var node = new Node(0);

        // Act
        var actualResult = node.IsLeaf;

        // Assert
        actualResult.Should().BeTrue();
    }

    [TestMethod]
    public void Node_ShouldNotBeLeafNode_WhenOneChildHasBeenInserted()
    {
        // Arrange
        var node = new Node(0);
        node.Insert(3);

        // Act
        var actualResult = node.IsLeaf;

        // Assert
        actualResult.Should().BeFalse();
    }
}