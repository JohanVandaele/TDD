namespace Woordteller;

public class Woordteller
{
    private static readonly char[] Separator = [' ', ','/*,'\r','\n'*/];

    public static int TelWoorden(string zin)
	{
		//throw new NotImplementedException();

		//var aantalWoorden = 0;
		//var index = 0;

		//while (index != zin.Length)
		//{
		//	while (index != zin.Length && (zin.ElementAt(index) == ' ' || zin.ElementAt(index) == ','))
		//		index++;

		//	if (index == zin.Length) continue;

		//	aantalWoorden++;

		//	while (index != zin.Length && zin.ElementAt(index) != ' ' && zin.ElementAt(index) != ',')
		//		index++;
		//}

		//return aantalWoorden;

		return zin.Split(Separator, StringSplitOptions.RemoveEmptyEntries).Length;
	}
}