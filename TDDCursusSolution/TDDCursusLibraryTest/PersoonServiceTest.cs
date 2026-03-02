using Moq;

namespace Personen;

[TestClass]
public class PersoonServiceTest
{
    private PersoonService service = null!;
    private IPersoonRepository repository = null!;
    private Mock<IPersoonRepository> mockFactory = null!;

    [TestInitialize]
    public void Initialize()
    {
        //service = new PersoonService();

        //var repository = new PersoonRepository();   // Dit is de repository die zal gebruikt worden
        //var repository = new PersoonRepositoryStub();

        // Aanmaken Mock
        mockFactory = new Mock<IPersoonRepository>();
        repository = mockFactory.Object;

        // Trainen Mock
        mockFactory.Setup(eenRepository => eenRepository
                .FindAllWeddes())
				.Returns([2, 4, 4, 4, 5, 5, 7, 9]);

        service = new PersoonService(repository);   // We injecteren deze repository in PersoonService
    }

    [TestMethod]
    // De StandaardAfwijking moet positief zijn
    public void StandaardAfwijkingWeddes_deWeddeStandaardAfwijking_IsPositief()
    {
        // Arrange
        // Act
        // Assert
        Assert.IsGreaterThan(0, service.StandaardAfwijkingWeddes());
    }

    [TestMethod]
    // De StandaardAfwijking moet gelijk zijn aan 2
    public void StandaardAfwijkingWeddes_deWeddeStandaardAfwijking_Moet2Zijn()
    {
        // Arrange
        // Act
        // Assert
        Assert.AreEqual(2, service.StandaardAfwijkingWeddes());

        mockFactory.Verify(eenRepository => eenRepository.FindAllWeddes());
    }
}
