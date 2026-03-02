namespace TDDCursusLibrary;

public class Artikel(decimal prijsExclusiefBtw, decimal btwPercentage)
{
    public decimal PrijsInclusiefBtw()
        => Math.Round(prijsExclusiefBtw * (100 + btwPercentage) / 100, 2, MidpointRounding.AwayFromZero);
}
