using System.Text.RegularExpressions;

namespace TDDCursusLibrary;

public class Rekeningnummer
{
    private static readonly Regex Regex = new("^BE(\\d{2})(\\d{12})$");
    private readonly string rekeningNummer;

    public Rekeningnummer(string rekeningNummer)
    {
        //throw new NotImplementedException();

        if (!Regex.IsMatch(rekeningNummer))
            throw new ArgumentException("Verkeerd formaat");

        var controleString = rekeningNummer.Substring(2, 2);
        var rekeningGetal = long.Parse(rekeningNummer[4..] + "1114" + controleString);
        var controleGetal = int.Parse(controleString);

        if (controleGetal < 2 || controleGetal > 98)
            throw new ArgumentException("1° of 2° cijfer verkeerd");

        if (rekeningGetal % 97 != 1)
            throw new ArgumentException("Nummer bevat verkeerde cijfers");

        this.rekeningNummer = rekeningNummer;
    }

    public override string ToString()
    {
        //throw new NotImplementedException();
        return rekeningNummer;
    }
}
