using System.Text.RegularExpressions;

namespace Paswoord;

public class Paswoord
{
	// Private
	private readonly Regex minstens1KleineLetter = new("^.*[a-z]{1,}.*$");
	private readonly Regex minstens1Hoofdletter = new ("^.*[A-Z]{1,}.*$");
	private readonly Regex minstens1Cijfer = new ("^.*[0-9]{1,}.*$");

	private readonly string waarde;

	// Constructor
	public Paswoord(string waarde)
	{
		//throw new NotImplementedException();

		if (waarde.Length < 8)
			throw new ArgumentException("Minstens 8 tekens");

		if (!minstens1KleineLetter.IsMatch(waarde))
			throw new ArgumentException("Minstens 1 kleine letter");

		//if (!new Regex("[a-z]").IsMatch(waarde))
		//    throw new ArgumentException("Geen enkele kleine letter!");

		if (!minstens1Hoofdletter.IsMatch(waarde))
			throw new ArgumentException("Minstens 1 hoofdletter");

		//if (!new Regex("[A-Z]").IsMatch(waarde))
		//    throw new ArgumentException("Geen enkele hoofdletter!");

		if (!minstens1Cijfer.IsMatch(waarde))
			throw new ArgumentException("Minstens 1 cijfer");

		//if (!new Regex("\\d").IsMatch(waarde))
		//    throw new ArgumentException("Geen enkel cijfer!");

		this.waarde = waarde;
	}

	public string Puntjes()
	{
		//throw new NotImplementedException();
		return new string('.', waarde.Length);
	}

	public bool KomtOvereenMet(string paswoord)
	{
		//throw new NotImplementedException();
		return waarde == paswoord;
	}
}