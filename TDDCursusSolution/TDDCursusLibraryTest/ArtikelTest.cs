using TDDCursusLibrary;

namespace TDDCursusLibraryTest;

[TestClass]
public class ArtikelTest
{
    [TestMethod]
    public void PrijsInclusiefBtw_Bedrag30enBtwPercentage6_Is31punt8()
    {
        // Arrange
        var artikel = new Artikel(30m, 6m);
        // Act
        // Assert
        Assert.IsTrue(artikel.PrijsInclusiefBtw().Equals(31.8m));
    }
}
