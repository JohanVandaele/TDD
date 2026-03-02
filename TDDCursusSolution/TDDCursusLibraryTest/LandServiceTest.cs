using Moq;

namespace Land;

[TestClass]
public class LandServiceTest
{
    private ILandDao landDao = null!;           // Stub
    private LandService landService = null!;    // Service : Te testen class
    private Mock<ILandDao> mockFactory = null!;

    [TestInitialize]
    public void Initialize()
    {
        //landDao = new LandDaoStub();

        // Mock object aanmaken
        mockFactory = new Mock<ILandDao>();
        landDao = mockFactory.Object;

        // Mock trainen
        mockFactory.Setup(eenLandDao => eenLandDao
                .FindOppervlakteAlleLanden())
                .Returns(20);

        mockFactory.Setup(eenLandDao => eenLandDao
                .Read("B"))
                .Returns(new Land { Landcode = "B", Oppervlakte = 5 });

        mockFactory.Setup(eenLandDao => eenLandDao
                .Read("NL"))
                .Returns(new Land { Landcode = "NL", Oppervlakte = 6 });

        mockFactory.Setup(eenLandDao => eenLandDao
                .Read(string.Empty))
                .Throws(new ArgumentException());

        // Aanmaken LandService met DI
        landService = new LandService(landDao);
    }

    [TestMethod]
    public void FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden()
    {
        Assert.AreEqual(0.25m,
            landService.FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));

        // hier gaan we straks verifiëren of landService de methods
        // read("B") en OppervlakteAlleALanden() heeft opgeroepen op landDao.

        mockFactory.Verify(eenLandDao => eenLandDao.FindOppervlakteAlleLanden());
        mockFactory.Verify(eenLandDao => eenLandDao.Read("B"));
    }
}