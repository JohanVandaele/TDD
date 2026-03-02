using MySql.Data.MySqlClient;
using System.Data;

namespace Woonplaats;

public class WoonplaatsDbsRepository : IWoonplaatsRepository
{
	// ----------------
	// FindMetStreepjes
	// ----------------
	public List<string> FindMetStreepjes()
	{
		var namen = new List<string>();

		try
		{
			using var conWoonplaats = new MySqlConnection();

			conWoonplaats.ConnectionString = @"server=127.0.0.1;uid=root;pwd=Root;database=nederland";

			var comWoonplaats = conWoonplaats.CreateCommand();
			comWoonplaats.CommandType = CommandType.Text;
			comWoonplaats.CommandText = "select naam from woonplaatsen where naam like '%-%'";

			conWoonplaats.Open();
			//Console.WriteLine("Woonplaats geopend");

			using var rdrWoonplaats = comWoonplaats.ExecuteReader();

			var naamIdPos = rdrWoonplaats.GetOrdinal("naam");

			while (rdrWoonplaats.Read())
				namen.Add(rdrWoonplaats.GetString(naamIdPos));
		}
		catch (Exception ex)
		{
			Console.WriteLine($"{ex.Message}");
		}

		return namen;
	}
}