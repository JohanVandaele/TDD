namespace TDDCursusLibrary;

public class Veiling
{
    private decimal hoogsteBod;

    public void DoeBod(decimal bedrag)
    {
        //throw new NotImplementedException();

        if (bedrag > hoogsteBod)
            hoogsteBod = bedrag;
    }

    public decimal HoogsteBod
    {
        get
        {
            //throw new NotImplementedException();
            return hoogsteBod;
        }
    }
}
