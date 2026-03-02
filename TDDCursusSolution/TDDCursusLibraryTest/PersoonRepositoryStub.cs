namespace Personen;

public class PersoonRepositoryStub : IPersoonRepository
{
    public decimal[] FindAllWeddes()
    {
        return [2m, 4m, 4m, 4m, 5m, 5m, 7m, 9m];
    }
}