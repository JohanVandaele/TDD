using TDDCursusLibrary;

namespace TDDCursusLibraryTest;

[TestClass]
public class RekeningnummerTest
{
    //[TestMethod]
    //// Nummer met 16 tekens en Correct Controle Is OK
    //public void New_MetCorrectNummerBE72091012240116_IsOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    _ = new Rekeningnummer("BE72091012240116");
    //}

    //[TestMethod]
    //// Nummer met 16 tekens en Correct Controle Is OK
    //public void New_MetCorrectNummerBE68539007547034_IsOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    new Rekeningnummer("BE68539007547034");
    //}

    //[TestMethod]
    //// Nummer met 16 tekens en Correct Controle Is OK
    //public void New_MetCorrectNummerBE02063588295840_IsOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    new Rekeningnummer("BE02063588295840"); // controlegetal < 10
    //}

    // Parameterized test voor correcte nummers
    [TestMethod]
    [DataRow("BE72091012240116")]
    [DataRow("BE68539007547034")]
    //[DataRow("BE68539007547034Ongeldig")]
    [DataRow("BE02063588295840")]
    public void CorrecteNummers(string rekeningNummer)
    {
        // Arrange
        // Act
        // Assert
        new Rekeningnummer(rekeningNummer);
    }

    //[TestMethod]
    //// Nummer met 17 tekens Is niet OK
    //public void New_MetTeLangNummer_IsNietOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Rekeningnummer("BE720910122401160");
    //    Assert.Throws<ArgumentException>(() => new Rekeningnummer("BE720910122401160"));
    //}

    //[TestMethod]
    //// Nummer met 15 tekens Is niet OK
    //public void New_MetTeKortNummer_IsNietOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Rekeningnummer("BE7209101224011");
    //    Assert.Throws<ArgumentException>(() => new Rekeningnummer("BE7209101224011"));
    //}

    //[TestMethod]
    //// Niet-Belgisch Nummer Is niet OK
    //public void New_NietBelgischNummer_IsNietOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Rekeningnummer("NL72091012240116"); // NL
    //    Assert.Throws<ArgumentException>(() => new Rekeningnummer("NL72091012240116"));    // NL
    //}

    //[TestMethod]
    //// Nummer met ongeldige tekens Is niet OK
    //public void New_NummerMetOngeldigeTekens_IsNietOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Rekeningnummer("BEX209101224011Y");
    //    Assert.Throws<ArgumentException>(() => new Rekeningnummer("BEX209101224011Y"));
    //}

    //[TestMethod]
    //// Nummer met te klein controlegetal Is niet OK
    //public void New_NummerMetTeKleinControlegetal_IsNietOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Rekeningnummer("BE01091012240116"); // 01
    //    Assert.Throws<ArgumentException>(() => new Rekeningnummer("BE01091012240116"));    // 01
    //}

    //[TestMethod]
    //// Nummer met te groot controlegetal Is niet OK
    //public void New_NummerMetTeGrootControlegetal_IsNietOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Rekeningnummer("BE99091012240116"); // 99
    //    Assert.Throws<ArgumentException>(() => new Rekeningnummer("BE99091012240116"));    // 99
    //}

    //[TestMethod]
    //// Nummer met verkeerde controleberekening Is niet OK
    //public void New_NummerMetVerkeerdeControleberekening_IsNietOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Rekeningnummer("BE72091012240115"); // 72
    //    Assert.Throws<ArgumentException>(() => new Rekeningnummer("BE72091012240115"));    // 72
    //}

    [TestMethod]
    // Nummer met NULL Is niet OK
    public void New_NummerMetNULL_IsNietOK()
    {
        // Arrange
        // Act
        // Assert
        //new Rekeningnummer(null!);
        Assert.Throws<ArgumentNullException>(() => new Rekeningnummer(null!));
    }

    //[TestMethod]
    //// Leeg Nummer Is niet OK
    //public void New_LeegNummer_IsNietOK()
    //{
    //    // Arrange
    //    // Act
    //    // Assert
    //    //new Rekeningnummer(String.Empty);
    //    Assert.Throws<ArgumentException>(() => new Rekeningnummer(string.Empty));
    //}

    // Parameterized test voor verkeerde nummers
    [TestMethod]
    [DataRow("BE720910122401160")]  // Te lang
    [DataRow("BE7209101224011")]    // Te kort
    [DataRow("NL72091012240116")]   // Niet Belgisch
    [DataRow("BEX209101224011Y")]   // Ongeldige tekens
    [DataRow("BE01091012240116")]   // Te klein controlegetal
    [DataRow("BE99091012240116")]   // Te groot controlegetal
    [DataRow("BE72091012240115")]   // Verkeerde controleberekening
    [DataRow("")]                   // Leeg
    public void VerkeerdeNummers(string rekeningNummer)
    {
        // Arrange
        // Act
        // Assert
        /*new Rekeningnummer(rekeningNummer)*/
        ;
        Assert.Throws<ArgumentException>(() => new Rekeningnummer(rekeningNummer));
    }

    [TestMethod]
    // ToString Moet Het Nummer Teruggeven
    public void ToString_RekeningNummer_MoetHetNummerTeruggeven()
    {
        // Arrange
        var nummer = "BE72091012240116";
        var rekeningnummer = new Rekeningnummer(nummer);
        // Act
        // Assert
        Assert.AreEqual(nummer, rekeningnummer.ToString());
    }
}
