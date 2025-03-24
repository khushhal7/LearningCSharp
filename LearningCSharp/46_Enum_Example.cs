

public enum Gender
{
    Unknown, 
    Male, 
    Female
}
public class _46_Employee
{
    public string Name { get; set; }
    public Gender Gender { get; set; }

    public static void showAll(List<_46_Employee> empList)
    {
        foreach (_46_Employee emp in empList)
        {
            Console.WriteLine(emp.Name);
            Console.WriteLine(getGender(emp.Gender));
        }
    }
    public static string getGender(Gender gender)
    {
        if (gender == Gender.Unknown)
        {
            return "Unknown";
        }
        else if (gender == Gender.Male) return "Male";
        else if (gender == Gender.Female) return "Female";
        return "Invalid Gender";
    }

}
public class _46_Enum_Example
{
    public static void Main()
    {
        List<_46_Employee> empList = new();
        empList.Add(new _46_Employee() { Name = "Karan", Gender = Gender.Unknown });
        empList.Add(new _46_Employee() { Name = "Manish", Gender = Gender.Male });
        empList.Add(new _46_Employee() { Name = "Komal", Gender = Gender.Female });
        _46_Employee.showAll(empList);

    }
}

