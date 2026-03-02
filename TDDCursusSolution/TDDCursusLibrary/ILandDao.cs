namespace Land;

public interface ILandDao
{
    Land Read(string landcode);
    int FindOppervlakteAlleLanden();
}
