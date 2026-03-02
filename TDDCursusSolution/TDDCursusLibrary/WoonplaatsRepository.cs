namespace Woonplaats;

public class WoonplaatsRepository : IWoonplaatsRepository
{
	public List<string> FindMetStreepjes()
	{
		List<string> woonplaatsen = null!;

		const string bestandNaam = @"woonplaatsen.txt";
		var directoryNaam = $@"{PathUp(Directory.GetCurrentDirectory(), 4)}\data";
		var pathNaam = $@"{directoryNaam}\{bestandNaam}";

		if (!Directory.Exists(directoryNaam))
			Console.WriteLine($"Directory {directoryNaam} bestaat niet.");
		else
		{
			if (!File.Exists(pathNaam))
				Console.WriteLine($"Het bestand {bestandNaam} bestaat niet.");
			else
				woonplaatsen = File.ReadLines(pathNaam).Where(w => w.Contains('-')).ToList();
		}

		return woonplaatsen;
	}

	private static string PathUp(string path, int aantal)
	{
		var p = path;
		for (var i = 1; i <= aantal; i++) p = Directory.GetParent(p)!.FullName;
		return p;
	}
}