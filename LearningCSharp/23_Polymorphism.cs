
public class _23_Base
{
    public virtual void function()
    {
        Console.WriteLine("In Base Class.");
    }
}
public class _23_Derive : _23_Base
{
    public override void function()
    {
        Console.WriteLine("In Derived Class.");
    }
}

public class _23_Polymorphism
{
    public static void Main(string[] args)
    {
        _23_Base obj = new _23_Derive();
        _23_Base obj2 = new();
        obj2.function();
        obj.function();
    }
}

