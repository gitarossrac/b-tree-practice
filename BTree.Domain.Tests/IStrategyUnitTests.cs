using BTree.Domain;
using BTree.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace BTree.Domain.Tests;

[TestClass]
public class IStrategyUnitTests
{
    [TestMethod]
    public void Execute_ShouldAcceptNode()
    {
        // Arrange
        var strategy = Substitute.For<IStrategy>();
        var node = new Node(0);

        // Act + Assert
        strategy.Execute(node);
    }
}