using TDDCursusLibrary;

namespace TDDCursusLibraryTest;

[TestClass]
public class RechthoekTest
{
    // Oppervlakte
    [TestMethod]
    public void Oppervlakte_Zijden5op3_Is15()
    {
        // Arrange
        // Act
        // Assert
        Assert.IsTrue(new Rechthoek(5, 3).Oppervlakte().Equals(15));
    }

    // Omtrek
    [TestMethod]
    public void Omtrek_Zijden5op3_Is16()
    {
        // Arrange
        // Act
        // Assert
        Assert.IsTrue(new Rechthoek(5, 3).Omtrek().Equals(16));
    }
}

