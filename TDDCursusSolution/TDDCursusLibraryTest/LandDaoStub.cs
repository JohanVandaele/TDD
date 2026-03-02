namespace Land;

public class LandDaoStub : ILandDao
{
    public Land Read(string landcode)
        => new Land { Landcode = landcode, Oppervlakte = 5 };

    public int FindOppervlakteAlleLanden()
        => 20;
}