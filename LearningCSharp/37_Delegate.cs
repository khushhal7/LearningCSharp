
//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }

//    public static void isPromoted(List<Employee> emp_list,isEligiblePromoted isEligible)
//    {
//        foreach(Employee emp in emp_list)
//        {
//            if (isEligible(emp))
//            {
//                Console.WriteLine($"{emp.Name} is Promoted.");
//            }
//        }
//    }

//}
////public delegate bool isEligiblePromoted(Employee emp);

//public class _37_Delegate
//{
//    public static void Main()
//    {
//        List<Employee> emp_list = new List<Employee>();
//        emp_list.Add(new Employee() { Id=101,Name="a",Salary=10000,Experience=5});
//        emp_list.Add(new Employee() { Id = 102, Name = "b", Salary = 20000, Experience = 5 });
//        emp_list.Add(new Employee() { Id = 103, Name = "c", Salary = 30000, Experience = 5 });
//        emp_list.Add(new Employee() { Id = 104, Name = "d", Salary = 40000, Experience = 8 });
//        emp_list.Add(new Employee() { Id = 105, Name = "e", Salary = 50000, Experience = 9 });
//        isEligiblePromoted del = new(isEligible);
//        Employee.isPromoted(emp_list, del);
//    }
//    public static bool isEligible(Employee emp)
//    {
//        if(emp.Experience >= 6)
//        {
//            return true;
//        }
//        return false;
//    }
//}