using Moq;

namespace Winst;

[TestClass]
public class WinstServiceTest
{
    private WinstService winstService = null!;
    private IKostRepository kostRepository = null!;
    private IOpbrengstRepository opbrengstRepository = null!;

    private Mock<IKostRepository> mockKostRepository = null!;
    private Mock<IOpbrengstRepository> mockOpbrengstRepository = null!;

    [TestInitialize]
    public void Initialize()
    {
        //kostRepository = new KostRepositoryStub();
        //opbrengstRepository = new OpbrengstRepositoryStub();

        // Aanmaken Mock
        mockKostRepository = new Mock<IKostRepository>();
        mockOpbrengstRepository = new Mock<IOpbrengstRepository>();

        kostRepository = mockKostRepository.Object;
        opbrengstRepository = mockOpbrengstRepository.Object;

        // Trainen Mock
        mockOpbrengstRepository.Setup(eenOpbrengstDao => eenOpbrengstDao
                .FindTotaleOpbrengst())
            .Returns(200m);

        mockKostRepository.Setup(eenKostRepository => eenKostRepository
                .FindTotaleKost())
            .Returns(169m);

        winstService = new WinstService(opbrengstRepository, kostRepository);
    }

    [TestMethod]
    public void Winst_BerekenOpbrengstMinKost_Is31()
    {
        Assert.AreEqual(31m, winstService.GetWinst);

        mockKostRepository.Verify(eenKostRepository => eenKostRepository.FindTotaleKost());
        mockOpbrengstRepository.Verify(eenOpbrengstRepository => eenOpbrengstRepository.FindTotaleOpbrengst());
    }
}
