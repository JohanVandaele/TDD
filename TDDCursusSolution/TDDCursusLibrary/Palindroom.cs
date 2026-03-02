namespace TDDCursusLibrary;

public class Palindroom(string woord)
{
    public bool IsPalindroom()
    {
        var omgekeerd = new string(woord.ToArray().Reverse().ToArray());
        return woord == omgekeerd;
    }

    public bool IsPalindroom01()
    {
        for (var teller = 0; teller < woord.Length / 2; teller++)
            if (woord[teller] != woord[woord.Length - 1 - teller]) return false;

        return true;
    }

    public bool IsPalindroom02() => woord == new string(woord.ToCharArray().Reverse().ToArray());
}
