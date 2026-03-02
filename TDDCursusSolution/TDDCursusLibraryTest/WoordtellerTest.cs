namespace Woordteller;

[TestClass]
public class WoordtellerTest
{
	private Woordteller woordteller = null!;

	[TestInitialize]
	public void Initialize()
	{
		woordteller = new Woordteller();
	}

	[TestMethod]
	//public void eenNullWaardeKanNiet()
	public void TelWoorden_Null_IsNietGeldig()
	{
		Assert.Throws<NullReferenceException>(() => Woordteller.TelWoorden(null!));
	}

	[TestMethod]
	[DataRow("")]
	[DataRow(" ")]
	[DataRow("  ")]
	[DataRow(",")]
	[DataRow(",,,")]
	[DataRow(" , ,, ")]
	// Parameterized test voor correcte nummers
	public void TelWoorden_Bevat0Woorden(string woord)
	{
		// Arrange
		// Act
		// Assert
		Assert.AreEqual(0, Woordteller.TelWoorden(woord));
	}

	[TestMethod]
	[DataRow("woord")]
	[DataRow(" woord")]
	[DataRow("woord ")]
	// Parameterized test voor correcte nummers
	public void TelWoorden_Bevat1Woord(string woord)
	{
		// Arrange
		// Act
		// Assert
		Assert.AreEqual(1, Woordteller.TelWoorden(woord));
	}

	[TestMethod]
	[DataRow("ik ook")]
	[DataRow("ik  ook")]
	[DataRow("ik,ook")]
	[DataRow("ik, ook")]
	[DataRow("ik , ook")]
	// Parameterized test voor correcte nummers
	public void TelWoorden_Bevat2Woorden(string woord)
	{
		// Arrange
		// Act
		// Assert
		Assert.AreEqual(2, Woordteller.TelWoorden(woord));
	}
}