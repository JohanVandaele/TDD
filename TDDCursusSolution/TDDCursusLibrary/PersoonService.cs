namespace Personen;

//public class PersoonService()
//public class PersoonService(PersoonRepository repository)
public class PersoonService(IPersoonRepository repository)
{
	// Private
	//private readonly PersoonRepository repository = new PersoonRepository();

	// StandaardAfwijkingWeddes
	//public decimal StandaardAfwijkingWeddes()

	public decimal StandaardAfwijkingWeddes()
	{
		//throw new NotImplementedException();

		var weddes = repository.FindAllWeddes();

		if ((weddes.Length <= 0)) return 0;

		var totaal = weddes.Sum();
		var gemiddelde = totaal / weddes.Length;

		//foreach (var wedde in weddes)
		//{
		//    var verschil = wedde - gemiddelde;
		//    var kwadraat = (decimal)Math.Pow((double)verschil, 2);
		//    totaal += kwadraat;
		//}
		totaal = weddes.Select(wedde => wedde - gemiddelde)
						.Select(verschil => (decimal)Math.Pow((double)verschil, 2))
						.Sum();

		var variantie = totaal / weddes.Length;
		var standaardAfwijking = (decimal)Math.Sqrt((double)variantie);

		return standaardAfwijking;
	}
}
