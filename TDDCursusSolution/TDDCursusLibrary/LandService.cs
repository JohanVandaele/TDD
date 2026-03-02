namespace Land;

//public class LandService
public class LandService(ILandDao landDao)
{
    ////private LandDao landDAO = new LandDao();	// Zonder Interface/DI : Verwijst slechts naar 1 bepaalde Class
    //private readonly ILandDao landDao;// = null!;  // Met Interface/DI    : Verwijst naar een Class die deze interface implementeert

    //// Constructor
    //public LandService(ILandDao landDao)
    //    => this.landDao = landDao;

    public decimal FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden(string landcode)
    {
        //throw new NotImplementedException();

        var land = landDao.Read(landcode);
        var oppervlakteAlleLanden = landDao.FindOppervlakteAlleLanden();
        return (decimal)land.Oppervlakte / oppervlakteAlleLanden;
    }
}