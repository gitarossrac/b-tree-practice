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

    [TestMethod]
    public void Insert_ShouldInsertNewNodeRight_WhenValueIsGreaterThanCurrentNodeValue()
    {
        // Arrange
        var node = new Node(0);
        var insertedNodeValue = 1;

        // Act
        node.Insert(insertedNodeValue);

        // Assert
        node.Right.Should().NotBeNull();
        node.Right.Value.Should().Be(insertedNodeValue);
        node.Left.Should().BeNull();
    }


    [TestMethod]
    public void Insert_ShouldInsertNewNodeLeft_WhenValueIsSmallerThanCurrentNodeValue()
    {
        // Arrange
        var node = new Node(0);
        var insertedNodeValue = -1;

        // Act
        node.Insert(insertedNodeValue);

        // Assert
        node.Left.Should().NotBeNull();
        node.Left.Value.Should().Be(insertedNodeValue);
        node.Right.Should().BeNull();
    }
}