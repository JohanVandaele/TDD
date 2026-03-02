namespace Periode;

public class Periode
{
	// Private
	private readonly DateOnly van;
	private readonly DateOnly tot;

	// Constructor
	public Periode(DateOnly van, DateOnly tot)
	{
		//throw new NotImplementedException();

		if (tot < van)
			throw new ArgumentException();

		this.van = van;
		this.tot = tot;
	}

	public bool KomtNa(Periode periode)
	{
		//throw new NotImplementedException();
		return van > periode.tot;
	}

	public bool OverlaptMet(Periode periode)
	{
		//throw new NotImplementedException();
		return tot.CompareTo(periode.van) >= 0 && van.CompareTo(periode.tot) <= 0;
	}
}