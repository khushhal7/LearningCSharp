
public class _44_ExceptionHandlingAbuse_Solution
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter Numerator : ");
            int fN;
            bool fNIsValid = Int32.TryParse(Console.ReadLine(),out fN);
            if(fNIsValid)
            {
                Console.WriteLine("Enter Denominator : ");
                int sN;
                bool sNIsValid = Int32.TryParse(Console.ReadLine(), out sN);
                if (sNIsValid)
                {
                    if(sN == 0)
                    {
                        Console.WriteLine("Denominator can't be Zero.");
                    }
                    else
                    {
                        int result = fN / sN;
                        Console.WriteLine($"Result : {result}");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Number in range {0} to {1}.", int.MinValue, int.MaxValue);
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Valid Number in range {0} to {1}.", int.MinValue, int.MaxValue);
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

