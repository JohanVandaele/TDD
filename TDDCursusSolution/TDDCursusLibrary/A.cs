namespace TDDCursusLibrary;

public class A
{
    private readonly B b = new B();

    public void A1()
    {
        // . . . . . . . . 
        //B b = new B();
        b.B1();
        // . . . . . . . . 
    }

    public int A2()
    {
        // . . . . . . . . 
        //B b = new B();
        b.B1();
        b.B2();
        // . . . . . . . . 

        return 1;
    }
}