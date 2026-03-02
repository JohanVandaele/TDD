using Personen;
using Woonplaats;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;

string? keuze = null;

IPersoonRepository repository = null!;
IWoonplaatsRepository woonplaatsRepository = null!;

while (keuze != "X")
{
	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine();
	//Console.WriteLine("===================================");
	//Console.WriteLine("S T A N D A A R D A F W I J K I N G");
	//Console.WriteLine("===================================");
	Console.WriteLine("=======");
	Console.WriteLine("M E N U");
	Console.WriteLine("=======");
	Console.WriteLine("Standaardafwijking");
	Console.WriteLine("1. Maak CSV bestand");
	Console.WriteLine("2. Bereken met CSV bestand");
	Console.WriteLine("3. Bereken met Keyboard");
	Console.WriteLine("4. Bereken met Database");
	Console.WriteLine("Woonplaatsen");
	//Console.WriteLine("5. Bepaal maximum aantal streepjes in woonplaatsen");
	Console.WriteLine("5. Bepaal maximum aantal streepjes in woonplaatsen - Text bestand");
	Console.WriteLine("6. Bepaal maximum aantal streepjes in woonplaatsen - Database");
	Console.WriteLine();
	Console.WriteLine("X. Terug");
	Console.WriteLine();

	Console.Write("> ");
	keuze = Console.ReadLine()!.ToUpper();

	//while (keuze != "1" && keuze != "2" && keuze != "3" && keuze != "4" && keuze != "X")
	//while (keuze != "1" && keuze != "2" && keuze != "3" && keuze != "4" && keuze != "5" && keuze != "X")
	while (keuze != "1" && keuze != "2" && keuze != "3" && keuze != "4" && keuze != "5" && keuze != "6" && keuze != "X")
	{
		Console.WriteLine($"Verkeerde keuze.");
		Console.Write("> ");
		keuze = Console.ReadLine()!.ToUpper();
	}

	switch (keuze)
	{
		case "1":
			MaakCsvBestand();
			break;

		case "2":
			repository = new PersoonCsvRepository();
			break;

		case "3":
			repository = new PersoonKbdRepository();
			break;

		case "4":
			repository = new PersoonDbsRepository();
			Console.WriteLine("Dit gedeelte wordt verder uitgewerkt in de module EF.");
			break;

		case "5":
			woonplaatsRepository = new WoonplaatsRepository();
			break;

		case "6":
			woonplaatsRepository = new WoonplaatsDbsRepository();
			break;

		case "X":
			break;

		default:
			break;
	}

	if ("234".Contains(keuze[0]))
		Console.WriteLine($"Standaardafwijking: {new PersoonService(repository).StandaardAfwijkingWeddes()}");

	//if ("5".Contains(keuze[0]))
	if ("56".Contains(keuze[0]))
		Console.WriteLine($"Maximum aantal streepjes: {new WoonplaatsService(woonplaatsRepository)
			.MaxAantalStreepjesInEenWoonplaats()}");
}

Console.WriteLine("\nWij danken u voor uw medewerking. Tot de volgend keer....");
Console.ReadKey();

// ----------------------------------------------------------------------------------------------------------

void MaakCsvBestand()
{
	string[] voornamen = { "Arthur", "Noa", "Adam", "Louis", "Liam", "Emma", "Olivia", "Louise", "Mila", "Alice" };
	string[] familienamen = { "Peeters", "Janssens", "Maes", "Jacobs", "Mertens", "Willems", "Claes", "Goossens"
		, "Wouters", "Desmet" };

	var bestandNaam = @"personen.csv";
	var directoryNaam = $@"{PathUp(Directory.GetCurrentDirectory(), 4)}\data";
	var pathNaam = $@"{directoryNaam}\{bestandNaam}";

	Console.WriteLine($"{pathNaam}");
	Console.WriteLine("Gelieve te wachten tot je de boodschap krijgt dat het bestand is aangemaakt.");

	if (!Directory.Exists(directoryNaam)) Directory.CreateDirectory(directoryNaam);
	if (File.Exists(pathNaam)) File.Delete(pathNaam);

	var random = new Random();

	using (StreamWriter sw = File.AppendText(pathNaam))
	{
		try
		{
			for (var i = 1; i <= 10000000; i++)
			{
				sw.WriteLine($"{i}" +
							 $";{voornamen[random.Next(voornamen.Length)]}" +
							 $";{familienamen[random.Next(familienamen.Length)]}" +
							 $";{2000m + (decimal)random.Next(3000) + (decimal)random.Next(100) / 100m}");
				//Console.WriteLine($"{i}");	// In commentaar voor snellere uitvoering van het programma
			}
		}
		catch (Exception e)
		{
			Console.WriteLine("Exception: " + e.Message);
		}
		//finally
		//{
		//	sw.Close();
		//	Console.WriteLine("Executing finally block.");
		//}
	}

	Console.WriteLine("Bestand aangemaakt");
}

// ----------------------------------------------------------------------------------------------------------

//// ----------------
//// Bestand aanmaken
//// ----------------

//string[] voornamen = ["Arthur", "Noa", "Adam", "Louis", "Liam", "Emma", "Olivia", "Louise", "Mila", "Alice"];
//string[] familienamen = [ "Peeters", "Janssens", "Maes", "Jacobs", "Mertens", "Willems", "Claes", "Goossens"
//    , "Wouters", "Desmet" ];

//const string bestandNaam = @"personen.csv";
//var directoryNaam = $@"{PathUp(Directory.GetCurrentDirectory(), 4)}\data";
//var pathNaam = $@"{directoryNaam}\{bestandNaam}";
//Console.WriteLine($"{pathNaam}");

//if (!Directory.Exists(directoryNaam)) Directory.CreateDirectory(directoryNaam);
//if (File.Exists(pathNaam)) File.Delete(pathNaam);

//var random = new Random();

//using (var sw = File.AppendText(pathNaam))
//{
//    try
//    {
//        for (var i = 1; i <= 10000000; i++)
//        {
//            sw.WriteLine($"{i}" +
//                         $";{voornamen[random.Next(voornamen.Length)]}" +
//                         $";{familienamen[random.Next(familienamen.Length)]}" +
//                         $";{2000m + (decimal)random.Next(3000) + (decimal)random.Next(100) / 100m}");
//            //Console.WriteLine($"{i}");	// In commentaar voor snellere uitvoering van het programma
//        }
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine("Exception: " + e.Message);
//    }
//    //finally
//    //{
//    //	sw.Close();
//    //	Console.WriteLine("Executing finally block.");
//    //}
//}

//Console.WriteLine("Bestand aangemaakt");

//// ---------
//// Productie
//// ---------
//try

//{
//    // Ook hier Dependency Injection
//    var service = new PersoonService(new PersoonCsvRepository());  // We gaan het object PersoonRepository gebruiken in onze PersoonService
//    Console.WriteLine(service.StandaardAfwijkingWeddes());
//}
//catch (Exception)
//{
//    Console.Error.WriteLine("Kan personen niet lezen.");
//}

// --------------------------------------------

static string PathUp(string path, int aantal)
{
	var p = path;
	for (var i = 1; i <= aantal; i++) p = Directory.GetParent(p)!.FullName;
	return p;
}

// --------------------------------------------
