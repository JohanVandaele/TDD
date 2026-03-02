using MySql.Data.MySqlClient;
using System.Data;

namespace Personen;

public class PersoonDbsRepository : IPersoonRepository
{
	// -------------
	// FindAllWeddes
	// -------------
	public decimal[] FindAllWeddes()
	{
		var weddes = new List<decimal>();

		try
		{
			using var conWeddebeheer = new MySqlConnection();

			conWeddebeheer.ConnectionString = @"server=127.0.0.1;uid=root;pwd=Root;database=weddebeheer";

			var comWeddebeheer = conWeddebeheer.CreateCommand();
			comWeddebeheer.CommandType = CommandType.Text;
			comWeddebeheer.CommandText = "select wedde from personen";

			conWeddebeheer.Open();
			//Console.WriteLine("Weddebeheer geopend");

			using var rdrWeddes = comWeddebeheer.ExecuteReader();

			var weddeIdPos = rdrWeddes.GetOrdinal("wedde");

			while (rdrWeddes.Read())
				weddes.Add(rdrWeddes.GetDecimal(weddeIdPos));
		}
		catch (Exception ex)
		{
			Console.WriteLine($"{ex.Message}");
		}

		return weddes.ToArray();
	}
}