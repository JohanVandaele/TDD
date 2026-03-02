namespace TDDCursusLibrary;

public class Jaar(int jaar)
{
    public bool IsSchrikkeljaar
    {
        //get
        //{
        //    if (jaar % 400 == 0)
        //        return true;

        //    if (jaar % 100 == 0)
        //        return false;

        //    return jaar % 4 == 0;
        //    //return jaar % 5 == 0;
        //}

        get => jaar % 4 == 0 && jaar % 100 != 0 || jaar % 400 == 0;
    }
}
