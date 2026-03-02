namespace Woonplaats;

[TestClass]
public class WoonplaatsServiceTest
{
	private WoonplaatsService service = null!;

	[TestInitialize]
	public void Initialize()
	{
		service = new WoonplaatsService(new WoonplaatsRepository());
	}

	[TestMethod(DisplayName = "Maximum aantal streepjes mag niet negatief zijn")]
	// De StandaardAfwijking moet positief zijn
	public void MaxAantalStreepjesInEenWoonplaats()
	{
		// Arrange
		// Act
		// Assert
		Assert.IsGreaterThan(0, service.MaxAantalStreepjesInEenWoonplaats());
	}
}