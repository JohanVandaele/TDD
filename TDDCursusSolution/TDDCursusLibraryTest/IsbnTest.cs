using TDDCursusLibrary;

namespace TDDCursusLibraryTest;

[TestClass]
public class IsbnTest
{
    //[TestMethod]
    //// Het Nummer 0 Is Verkeerd
    //public void New_MetNummer0_IsVerkeerd()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Isbn(0);
    //    Assert.Throws<ArgumentException>(() => new Isbn(0));
    //}

    //[TestMethod]
    //// Een Negatief Nummer Is Verkeerd
    //public void New_MetEenNegatiefNummer_IsVerkeerd()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Isbn(-9789027439642L);
    //    Assert.Throws<ArgumentException>(() => new Isbn(-9789027439642L));
    //}

    //[TestMethod]
    //// Een Nummer Met 12 Cijfers Is Verkeerd
    //public void New_MetEenNummerVan12Cijfers_IsVerkeerd()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Isbn(978902743964L);
    //    Assert.Throws<ArgumentException>(() => new Isbn(978902743964L));
    //}

    //[TestMethod]
    //// Een Nummer Met 14 Cijfers Is Verkeerd
    //public void New_MetEenNummerVan14Cijfers_IsVerkeerd()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Isbn(97890274396421L);
    //    Assert.Throws<ArgumentException>(() => new Isbn(97890274396421L));
    //}

    //[TestMethod]
    //// De Eerste 3 Cijfers Moeten 978 of 979 Zijn
    //public void New_Eerste3Cijfers978Of979_IsVerkeerd()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Isbn(9779227439643L);
    //    Assert.Throws<ArgumentException>(() => new Isbn(9779227439643L));
    //}

    //[TestMethod]
    //// Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 2
    //public void New_MetEenNummerVan13CijfersMetVerkeerdControleGetal2_IsVerkeerd()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Isbn(8789027439642L);
    //    Assert.Throws<ArgumentException>(() => new Isbn(8789027439642L));
    //}

    //[TestMethod]
    //// Een Nummer Met 13 Cijfers Met Correct ControleGetal 2
    //public void New_MetEenNummerVan13CijfersMetCorrectControleGetal2_IsCorrect()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    _ = new Isbn(9789027439642L);
    //}

    //[TestMethod]
    //// Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 3
    //public void New_MetEenNummerVan13CijfersMetVerkeerdControleGetal3_IsVerkeerd()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Isbn(9789027439643L);
    //    Assert.Throws<ArgumentException>(() => new Isbn(9789027439643L));
    //}

    //[TestMethod]
    //// Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 0
    //public void New_MetEenNummerVan13CijfersMetVerkeerdControleGetal0_IsVerkeerd()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Isbn(7789227439640L);
    //    Assert.Throws<ArgumentException>(() => new Isbn(7789227439640L));
    //}

    //[TestMethod]
    //// Een Nummer Met 13 Cijfers Met Correct ControleGetal 0
    //public void New_MetEenNummerVan13CijfersMetCorrectControleGetal0_IsCorrect()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    new Isbn(9789227439640L);
    //}

    // Parameterized test voor correcte nummers
    [TestMethod]
    [DataRow(9789027439642L)]       // Een Nummer Met 13 Cijfers Met Correct ControleGetal 2
    [DataRow(9789227439640L)]       // Een Nummer Met 13 Cijfers Met Correct ControleGetal 0
    public void CorrecteNummers(long isbnNummer)
    {
        // Arrange
        // Act
        // Assert
        new Isbn(isbnNummer);
    }

    // Parameterized test voor incorrecte nummers
    [TestMethod]
    [DataRow(0)]                    // Het nummer 0 is verkeerd
    [DataRow(-9789027439642L)]      // Een negatief nummer is verkeerd
    [DataRow(978902743964L)]        // Een nummer met 12 cijfers is verkeerd
    [DataRow(97890274396421L)]      // Een nummer met 14 cijfers is verkeerd
    [DataRow(9779227439643L)]       // De Eerste 3 Cijfers Moeten 978 of 979 Zijn
    [DataRow(8789027439642L)]       // Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 2
    [DataRow(9789027439643L)]       // Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 3
    [DataRow(7789227439640L)]       // Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 0
    public void VerkeerdeNummers(long isbnNummer)
    {
        // Arrange
        // Act
        // Assert
        //new Isbn(isbnNummer);
        Assert.Throws<ArgumentException>(() => new Isbn(isbnNummer));
    }

    [TestMethod]
    // ToString moet het nummer teruggeven
    public void ToString_ISBNNummer_MoetHetNummerTeruggeven()
    {
        // Arrange
        var nummer = 9789227439640L;
        var isbnNummer = new Isbn(nummer);
        // Act
        // Assert
        Assert.AreEqual(nummer.ToString(), isbnNummer.ToString());
    }
}
