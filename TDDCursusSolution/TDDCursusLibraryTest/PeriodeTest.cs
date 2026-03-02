namespace Periode;

[TestClass]
public class PeriodeTest
{
	private DateOnly datum20220101;
	private DateOnly datum20220109;
	private Periode periode1 = null!;
	private Periode periode2 = null!;

	[TestInitialize]
	public void Initialize()
	{
		datum20220101 = new DateOnly(2022, 1, 1);
		datum20220109 = new DateOnly(2022, 1, 9);

		periode1 = new Periode(datum20220101, datum20220109);
		periode2 = new Periode(new DateOnly(2022, 2, 1), new DateOnly(2022, 2, 9));
	}

	//[TestMethod]
	//public void vanMoetIngevuldZijn()
	//{
	//	Assert.Throws<NullReferenceException>(() => new Periode(null, datum20220101));
	//}

	//[TestMethod]
	//public void totMoetIngevuldZijn()
	//{
	// 	Assert.Throws<NullReferenceException>(() => new Periode(datum20220101, null));
	//}

	[TestMethod]
	public void New_totMoetGroterOfGelijkZijnDanVan()
	{
		Assert.Throws<ArgumentException>(() => new Periode(datum20220109, datum20220101));
	}

	[TestMethod]
	public void New_eenPeriodeVanEenDagIsOK()
	{
		new Periode(datum20220101, datum20220101);
	}

	[TestMethod]
	public void KomtNa_periodeInKomtNaMoetIngevuldZijn()
	{
		Assert.Throws<NullReferenceException>(() => periode1.KomtNa(null!));
	}

	[TestMethod]
	public void KomtNa_eenPeriodeKomtNaEenPeriodeDieOuderIs()
	{
		Assert.IsTrue(periode2.KomtNa(periode1));
	}

	[TestMethod]
	public void KomtNa_eenPeriodeKomtNietNaEenPeriodeDieJongerIs()
	{
		Assert.IsFalse(periode1.KomtNa(periode2));
	}

	[TestMethod]
	public void KomtNa_eenPeriodeKomtNietNaEenPeriodeMetGelijkeVans()
	{
		Assert.IsFalse(new Periode(new DateOnly(2022, 1, 1), new DateOnly(2022, 1, 10)).KomtNa(periode1));
	}

	[TestMethod]
	public void OverlaptMet_periodeInOverlaptMetMoetIngevuldZijn()
	{
		Assert.Throws<NullReferenceException>(() => periode1.OverlaptMet(null!));
	}

	[TestMethod]
	public void OverlaptMet_eenPeriodeOverlaptMetZichzelf()
	{
		Assert.IsTrue(periode1.OverlaptMet(periode1));
	}

	[TestMethod]
	public void OverlaptMet_eenPeriodeOverlaptNietMetEenPeriodeNaDeEerstePeriode()
	{
		Assert.IsFalse(periode1.OverlaptMet(periode2));
	}

	[TestMethod]
	public void OverlaptMet_eenPeriodeOverlaptNietMetEenPeriodeVoorDeEerstePeriode()
	{
		Assert.IsFalse(periode2.OverlaptMet(periode1));
	}

	[TestMethod]
	public void OverlaptMet_eenPeriodeOverlaptMetEenPeriodeMetEenVanInDeEerstePeriode()
	{
		Assert.IsTrue(periode1.OverlaptMet(new Periode(new DateOnly(2022, 1, 2)
			, new DateOnly(2022, 1, 15))));
	}

	[TestMethod]
	public void OverlaptMet_eenPeriodeOverlaptMetEenPeriodMetEenTotInDeEerstePeriode()
	{
		Assert.IsTrue(periode1.OverlaptMet(new Periode(new DateOnly(2021, 12, 31)
			, new DateOnly(2022, 1, 5))));
	}

	[TestMethod]
	public void OverlaptMet_eenPeriodeOverlaptMetEenPeriodeDieHelemaalInDeEerstePeriodeLigt()
	{
		Assert.IsTrue(periode1.OverlaptMet(new Periode(new DateOnly(2022, 1, 2)
			, new DateOnly(2022, 1, 3))));
	}

	[TestMethod]
	public void OverlaptMet_eenPeriodeOverlaptMetEenPeriodeMetGelijkeVans()
	{
		Assert.IsTrue(periode1.OverlaptMet(new Periode(new DateOnly(2022, 1, 1)
			, new DateOnly(2022, 1, 10))));
	}

	[TestMethod]
	public void OverlaptMet_eenPeriodeOverlaptMetEenPeriodeMetGelijkeTots()
	{
		Assert.IsTrue(periode1.OverlaptMet(new Periode(new DateOnly(2021, 12, 31)
			, new DateOnly(2022, 1, 9))));
	}
}
