using TDDCursusLibrary;

namespace TDDCursusLibraryTest;

[TestClass]
public class VeilingTest
{
    private Veiling veiling = null!;

    [TestInitialize]
    public void Initialize()
    {
        veiling = new Veiling();
    }

    // Het Hoogste Bod Van Een Nieuwe Veiling Staat Op Nul
    [TestMethod]
    public void HoogsteBod_NieuweVeiling_HoogsteBodIsNul()
    {
        // Arrange
        // Act
        // Assert
        Assert.AreEqual(0m, new Veiling().HoogsteBod);
    }

    // Na Een Eerste Bod Is Het Hoogste Bod Gelijk Aan Het Bedrag Van Dit Bod
    [TestMethod]
    public void HoogsteBod_NaEersteBod_HoogsteBodGelijkAanHetBod()
    {
        // Arrange
        //var veiling = new Veiling();

        // Act
        veiling.DoeBod(100m);

        // Assert
        Assert.AreEqual(100m, veiling.HoogsteBod);
    }

    // Na Meerdere Biedingen Is Het Hoogste Bod Gelijk Aan Het Bedrag Van Dit Bod
    [TestMethod]
    public void HoogsteBod_NaMeerdereBiedingen_HoogsteBodIsHoogsteBieding()
    {
        // Arrange
        //var veiling = new Veiling();

        // Act
        veiling.DoeBod(100m);
        veiling.DoeBod(200m);
        veiling.DoeBod(150m);

        // Assert
        Assert.AreEqual(200, veiling.HoogsteBod);
    }
}
