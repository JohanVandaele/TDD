using TDDCursusLibrary;

namespace TDDCursusLibraryTest;

[TestClass]
public class PalindroomTest
{
    // Lepel Is Een Palindroom
    [TestMethod]
    public void IsPalindroom_lepel_IsEenPalindroom()
    {
        // Arrange
        // Act
        // Assert
        Assert.IsTrue(new Palindroom("lepel").IsPalindroom());
    }

    // Vork Is Geen Palindroom
    [TestMethod]
    public void IsPalindroom_vork_IsGeenPalindroom()
    {
        // Arrange
        // Act
        // Assert
        Assert.IsFalse(new Palindroom("vork").IsPalindroom());
    }

    // Een Lege String Is Een Palindroom
    [TestMethod]
    public void IsPalindroom_EenLegeString_IsEenPalindroom()
    {
        // Arrange
        // Act
        // Assert
        Assert.IsTrue(new Palindroom(string.Empty).IsPalindroom());
    }
}

