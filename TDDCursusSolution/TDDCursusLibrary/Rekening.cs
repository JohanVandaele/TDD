namespace TDDCursusLibrary;

public class Rekening
{
    private decimal saldo;
    private List<decimal> stortingen = [];

    public void Storten(decimal bedrag)
    {
        //throw new NotImplementedException();

        if (bedrag <= decimal.Zero)
        //if (bedrag < decimal.Zero)
            throw new ArgumentException("Het bedrag moet positief zijn");

        saldo += bedrag;
        stortingen.Add(bedrag);
    }

    public decimal Saldo
    {
        get
        {
            //throw new NotImplementedException();
            return saldo;
        }
    }

    public List<decimal> Stortingen()
    {
        //throw new NotImplementedException();
        return stortingen;
    }

    public List<decimal> StortingenGesorteerd()
    {
        //throw new NotImplementedException();

        decimal[] arrayGesorteerd = stortingen.ToArray();
        Array.Sort<decimal>(arrayGesorteerd);
        var listGesorteerd = arrayGesorteerd.ToList();

        return listGesorteerd;
    }
}
