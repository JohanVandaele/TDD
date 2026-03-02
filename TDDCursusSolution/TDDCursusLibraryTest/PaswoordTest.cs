namespace Paswoord;

[TestClass]
public class PaswoordTest
{
	[TestMethod]
	public void New_Joske123IsEenCorrectPaswoord()
	{
		new Paswoord("Joske123");
	}

	[TestMethod]
	[DataRow("1234567")]
	[DataRow("1234567A")]
	[DataRow("1234567a")]
	[DataRow("AaBbCcDd")]
	public void VerkeerdPaswoord(string pw)
	{
		Assert.Throws<ArgumentException>(() => new Paswoord(pw));
	}

	[TestMethod]
	public void Puntjes_PuntjesZijnEvenLangAlsHetPaswoord()
	{
		Assert.AreEqual("........", new Paswoord("Joske123").Puntjes());
	}

	[TestMethod]
	public void KomtOvereenMet_eenPaswoordKomtOvereenMetZichZelf()
	{
		var pw = "Joske123";
		Assert.IsTrue(new Paswoord(pw).KomtOvereenMet(pw));
	}

	[TestMethod]
	public void nullIsEenOngeldigPaswoord()
	{
		Assert.Throws<NullReferenceException>(() => new Paswoord(null!));
	}
}