namespace TDDCursusLibrary;

public class Rechthoek(int lengte, int breedte)
{
    public int Oppervlakte() => lengte * breedte;

    public int Omtrek() => (lengte + breedte) * 2;
}
