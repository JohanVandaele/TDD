namespace Personen;

public class PersoonKbdRepository : IPersoonRepository
{
	// -------------
	// FindAllWeddes
	// -------------
	public decimal[] FindAllWeddes()
	{
		var weddes = new List<decimal>();

		for (; ; )
		{
			var wedde = LeesDecimal("Geef wedde:", 0m, 10000m);
			if (wedde == null) break;
			weddes.Add((decimal)wedde);
		}

		return weddes.ToArray();
	}

	// -----------
	// LeesDecimal
	// -----------
	public static decimal? LeesDecimal(string label, decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
	{
		string input;
		var decimalParse = 0m;

		while (true)
		{
			Console.Write($"{label}");
			input = Console.ReadLine()!;

			if (!string.IsNullOrWhiteSpace(input))
			{
				if (!decimal.TryParse(input, out decimalParse))
				{
					Console.WriteLine("Ongeldig getal...");
					continue;
				}

				if (decimalParse < min || decimalParse > max)
				{
					Console.WriteLine($"Het getal moet liggen tussen {min} en {max}...");
					continue;
				}
			}

			break;
		}

		return string.IsNullOrWhiteSpace(input) ? null : decimalParse;
	}
}