namespace TDDCursusLibrary;

public class Converter
{
    private const decimal AantalCentimeterInEenInch = 2.54m;

    public decimal InchesNaarCentimeters(decimal inches)
        => inches * AantalCentimeterInEenInch;
}
