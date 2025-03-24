

public enum _47_Gender
{
    Unknown,
    Male,
    Female
}

// explicitly converting underlying enum type from integer type to short.
public enum department : short
{
    HR = 5,
    Management = 10,
    Sales = 15,
    Tech = 20
}

public class _47_Enums
{
    public static void Main()
    {
        int[] Values = (int[])Enum.GetValues(typeof(_47_Gender));
        string[] Names = Enum.GetNames(typeof(_47_Gender));

        int length = Values.Length;

        for(int i=0; i<length; i++)
        {
            Console.WriteLine("Value : {0}, Gender : {1}", Values[i], Names[i]);
        }

        //foreach(int values in Values)
        //{
        //    Console.WriteLine(values);
        //}

        //foreach(string names in Names)
        //{
        //    Console.WriteLine(names);
        //}


        Gender gender = (Gender)0;
        int val = (int)Gender.Unknown;
        Console.WriteLine("Gender is : {0}, Value assosiated with gender is : {1}",gender,val);
    }
}

