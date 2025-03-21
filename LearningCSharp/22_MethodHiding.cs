
public class _22_Base
{
    public void function()
    {
        Console.WriteLine("We're in Base Class.");
    }
}
public class _22_Derive : _22_Base
{
    public new void function()
    {
        Console.WriteLine("We're in Derived Class.");
    }
}
public class _22_Derive2 : _22_Base
{
    public new void function()
    {
        base.function();
    }
}
public class _22_MethodHiding
{
    public static void Main()
    {
        _22_Derive obj = new();
        obj.function();
        _22_Base obj1 = new _22_Derive();
        obj1.function();
        _22_Derive2 obj2 = new();
        obj2.function();
        ((_22_Base)obj2).function();
    }

}
