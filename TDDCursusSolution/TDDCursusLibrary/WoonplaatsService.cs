namespace Woonplaats;

public class WoonplaatsService(IWoonplaatsRepository repository)
{
	public long MaxAantalStreepjesInEenWoonplaats()
	{
		//throw new NotImplementedException();
		return repository.FindMetStreepjes().Select(s => s.Count(x => x == '-')).Max();
	}
}