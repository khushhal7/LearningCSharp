

//public class _38_Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }

//    public static void isPromoted(List<_38_Employee> emp_list, isEligiblePromoted isEligible)
//    {
//        foreach (_38_Employee emp in emp_list)
//        {
//            if (isEligible(emp))
//            {
//                Console.WriteLine($"{emp.Name} is Promoted.");
//            }
//        }
//    }
//}


//public delegate bool isEligiblePromoted(_38_Employee emp);
//public class _38_Delegate_Usage
//{
//    public static void Main()
//    {
//        List<_38_Employee> emp_list = new List<_38_Employee>();
//        emp_list.Add(new _38_Employee() { Id = 101, Name = "a", Salary = 10000, Experience = 5 });
//        emp_list.Add(new _38_Employee() { Id = 102, Name = "b", Salary = 20000, Experience = 5 });
//        emp_list.Add(new _38_Employee() { Id = 103, Name = "c", Salary = 30000, Experience = 5 });
//        emp_list.Add(new _38_Employee() { Id = 104, Name = "d", Salary = 40000, Experience = 8 });
//        emp_list.Add(new _38_Employee() { Id = 105, Name = "e", Salary = 50000, Experience = 9 });
//        isEligiblePromoted del = new(isEligible);
//        _38_Employee.isPromoted(emp_list, isEligible);
//    }
//    public static bool isEligible(_38_Employee emp)
//    {
//        if (emp.Experience >= 6)
//        {
//            return true;
//        }
//        return false;
//    }
//}

