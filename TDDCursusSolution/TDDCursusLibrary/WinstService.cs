namespace Winst;

public class WinstService(IOpbrengstRepository opbrengstRepository, IKostRepository kostRepository)
{
    // Private

    // Constructor

    // Methods
    public decimal GetWinst
    {
        get
        {
            //throw new NotImplementedException();
            return opbrengstRepository.FindTotaleOpbrengst() - kostRepository.FindTotaleKost();
        }
    }
}