namespace TDDCursusLibrary;

public static class Statistiek
{
    public static decimal Gemiddelde(decimal[] getallen)
    {
        //throw new NotImplementedException();

        ArgumentNullException.ThrowIfNull(getallen, "Mag niet null zijn");

        if (getallen.Length == 0)
            throw new ArgumentException("Het aantal getallen moet groter zijn dan 0");

        //var totaal = getallen.Sum();

        //return totaal / getallen.Length;

        return getallen.Average();
    }
}
