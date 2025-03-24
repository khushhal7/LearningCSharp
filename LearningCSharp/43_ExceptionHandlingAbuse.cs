


/// <summary>
/// Exception Handling Abuse indicates that we have to write multiple catch for various types of exception
/// which is not a good programming pratice. For Solution to it we can use programming logic and showing user the error as warning.
/// the implementation of the solution is in next code.
/// </summary>
public class _43_ExceptionHandlingAbuse
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter Numerator : ");
            int fN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Denominator : ");
            int sN = Convert.ToInt32(Console.ReadLine());
            int result = fN / sN;
            Console.WriteLine("Result : {0}", result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please Enter a Valid Number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Please Enter a Valid Number in between {0} and {1}", int.MinValue, int.MaxValue);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Denominator can't be Zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

