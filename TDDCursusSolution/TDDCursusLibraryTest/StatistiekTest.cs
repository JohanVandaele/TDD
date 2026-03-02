using TDDCursusLibrary;

namespace TDDCursusLibraryTest;

[TestClass]
public class StatistiekTest
{
    [TestMethod]
    // Het Gemiddelde Van 10 en 15 is 12.5
    public void Gemiddelde_Van10en15_is12punt5()
    {
        // Arrange
        // Act
        // Assert
        Assert.AreEqual(12.5m, Statistiek.Gemiddelde(new decimal[] { 10m, 15m }));
    }

    [TestMethod]
    // Het Gemiddelde Van Een Getal Is Dat Getal
    public void Gemiddelde_VanEenGetal_IsDatGetal()
    {
        // Arrange
        const decimal enigGetal = 1.23m;
        // Act
        // Assert
        Assert.AreEqual(enigGetal, Statistiek.Gemiddelde(new decimal[] { enigGetal }));
    }

    [TestMethod]
    // Het Gemiddelde Van Een Lege Verzameling Kan Je Niet Berekenen
    public void Gemiddelde_VanEenLegeVerzameling_KanJeNietBerekenen()
    {
        // Arrange
        // Act
        // Assert
        //Statistiek.Gemiddelde(new decimal[] { });
        Assert.Throws<ArgumentException>(() => Statistiek.Gemiddelde(new decimal[] { }));
    }

    [TestMethod]
    // Het Gemiddelde Van Null Kan Je Niet Berekenen
    public void Gemiddelde_VanNull_KanJeNietBerekenen()
    {
        // Arrange
        // Act
        // Assert
        //Statistiek.Gemiddelde(null!);
        Assert.Throws<ArgumentNullException>(() => Statistiek.Gemiddelde(null!));
    }
}
