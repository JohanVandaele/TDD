using TDDCursusLibrary;

namespace TDDCursusLibraryTest;

[TestClass]
public sealed class JaarTest
{
    //[TestMethod]
    //public void TestMethod1()
    //{
    //}

    // Een Jaar Deelbaar Door 400 Is Een Schrikkeljaar
    //[TestMethod]
    [TestMethod(DisplayName = "Een Jaar Deelbaar Door 400 Is Een Schrikkeljaar")]
    public void IsSchrikkeljaar_DeelbaarDoor400_IsEenSchrikkeljaar()
    {
        // Arrange
        // Act
        // Assert
        //Assert.AreEqual(true, new Jaar(2000).IsSchrikkeljaar);
        Assert.IsTrue(new Jaar(2000).IsSchrikkeljaar);
    }

    // Een Jaar Deelbaar Door 100 Maar Niet Door 400 Is Geen Schrikkeljaar
    [TestMethod]
    public void IsSchrikkeljaar_DeelbaarDoor100MaarNietDoor400_IsGeenSchrikkeljaar()
    {
        // Arrange
        // Act
        // Assert
        //Assert.AreEqual(false, new Jaar(1900).IsSchrikkeljaar);
        Assert.IsFalse(new Jaar(1900).IsSchrikkeljaar);
    }

    // Een Jaar Deelbaar Door 4 Is Een Schrikkeljaar
    [TestMethod]
    public void IsSchrikkeljaar_DeelbaarDoor4_IsEenSchrikkeljaar()
    {
        // Arrange
        // Act
        // Assert
        //Assert.AreEqual(true, new Jaar(2012).IsSchrikkeljaar);
        Assert.IsTrue(new Jaar(2012).IsSchrikkeljaar);
    }

    // Een Jaar Niet Deelbaar Door 4 Is Geen Schrikkeljaar
    [TestMethod]
    public void IsSchrikkeljaar_NietDeelbaarDoor4_IsGeenSchrikkeljaar()
    {
        // Arrange
        // Act
        // Assert
        //Assert.AreEqual(false, new Jaar(2015).IsSchrikkeljaar);
        Assert.IsFalse(new Jaar(2015).IsSchrikkeljaar);
    }
}
