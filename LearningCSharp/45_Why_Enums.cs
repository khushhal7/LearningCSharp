

// In this program we will understand the need of using enum, although we are not
// using enums in the current program but will use in next program to implement the same thing.
// We can make the Gender enum type so it can became more readable, gender names in the form of strings instead of integers.
public class _45_Employee
{
    public string Name { get; set; }
    public int Gender { get; set; }

    public static void showAll(List<_45_Employee> empList)
    {
        foreach(_45_Employee emp in empList){
           Console.WriteLine(emp.Name);
           Console.WriteLine(getGender(emp.Gender));
        }
    }
    public static string getGender(int gender)
    {
        if (gender == 0)
        {
            return "Unknown";
        }
        else if (gender == 1) return "Male";
        else if (gender == 2) return "Female";
        return "Invalid Gender";
    }
    
}
public class _45_Why_Enums
{
    public static void Main()
    {
        List<_45_Employee> empList = new();
        empList.Add(new _45_Employee() { Name = "Karan", Gender = 1 });
        empList.Add(new _45_Employee() { Name = "Manish", Gender = 1 });
        empList.Add(new _45_Employee() { Name = "Komal", Gender = 2 });
        _45_Employee.showAll(empList);

    }
}

