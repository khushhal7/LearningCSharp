

// defining a delegate
public delegate void del_fun(string str);
class _36_Delegate
{
    public static void Main()
    {
        // initializing delegate
        del_fun del = new del_fun(function);
        del("Hi!");
    }
    public static void function(string str)
    {
        Console.WriteLine("Printing following message using delegates, " + str);
    }
}
