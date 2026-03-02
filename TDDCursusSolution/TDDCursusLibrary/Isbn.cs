namespace TDDCursusLibrary;

public class Isbn
{
    private const long GrootsteGetalMet13Cijfers = 9999999999999L;
    private const long KleinsteGetalMet13Cijfers = 1000000000000L;
    private readonly List<short> mogelijkeEerste3Cijfers = [978, 979];
    private readonly long nummer;

    public Isbn(long nummer)
    {
        //throw new NotImplementedException();

        if (nummer < KleinsteGetalMet13Cijfers || nummer > GrootsteGetalMet13Cijfers)
            throw new ArgumentException("Bevat geen 13 cijfers");

        var eerste3Cijfers = (short)(nummer / 10000000000L);

        if (!mogelijkeEerste3Cijfers.Contains(eerste3Cijfers))
            throw new ArgumentException("Begint niet met " + mogelijkeEerste3Cijfers);

        var somEvenCijfers = 0L;
        var somOnEvenCijfers = 0L;
        var teVerwerkenCijfers = nummer / 10;

        for (int teller = 0; teller != 6; teller++)
        {
            somEvenCijfers += teVerwerkenCijfers % 10;
            teVerwerkenCijfers /= 10;
            somOnEvenCijfers += teVerwerkenCijfers % 10;
            teVerwerkenCijfers /= 10;
        }

        var controleGetal = somEvenCijfers * 3 + somOnEvenCijfers;
        var naastGelegenHoger10Tal = controleGetal - controleGetal % 10 + 10;
        var verschil = naastGelegenHoger10Tal - controleGetal;
        var laatsteCijfer = nummer % 10;

        if (verschil == 10)
        {
            if (laatsteCijfer != 0)
                throw new ArgumentException("Verkeerd controlegetal");
        }
        else
        if (laatsteCijfer != verschil)
            throw new ArgumentException("Verkeerd controlegetal");

        this.nummer = nummer;
    }

    public override string ToString()
    {
        //throw new NotImplementedException();
        return nummer.ToString();
    }
}
