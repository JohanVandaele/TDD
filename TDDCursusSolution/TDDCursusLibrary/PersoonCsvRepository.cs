namespace Personen;

//public class PersoonRepository
public class PersoonCsvRepository : IPersoonRepository
{
	// -------------
	// FindAllWeddes
	// -------------
	public decimal[] FindAllWeddes()
    {
        //var weddes = File.ReadLines($@"{PathUp(Directory.GetCurrentDirectory(), 4)}\data\" + @"personen.csv")
        //    .Select(l => Convert.ToDecimal(l.Split(';')[3])).ToArray();
        //return weddes;

        decimal[] weddes = [0];

        var bestandNaam = @"personen.csv";
        var directoryNaam = $@"{PathUp(Directory.GetCurrentDirectory(), 4)}\data";
        var pathNaam = $@"{directoryNaam}\{bestandNaam}";

        if (!Directory.Exists(directoryNaam))
	        Console.WriteLine($"Directory {directoryNaam} bestaat niet.");
        else
        {
	        if (!File.Exists(pathNaam))
		        Console.WriteLine($"Het bestand {bestandNaam} bestaat niet.");
	        else
		        weddes = File.ReadLines(pathNaam).Select(l => Convert.ToDecimal(l.Split(';')[3])).ToArray();
        }

        return weddes;
	}

	private static string PathUp(string path, int aantal)
    {
        var p = path;
        for (var i = 1; i <= aantal; i++) p = Directory.GetParent(p)!.FullName;
        return p;
    }
}