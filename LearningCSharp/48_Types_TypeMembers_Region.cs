

public class _48_Employee
{
    #region Fields
    private int id;
    private string fname;
    private string sname;
    #endregion

    #region Properties
    public int ID{
        set{ this.id = value; }
        get{ return this.id; }
    }
    public string FNAME
    {
        set { this.fname = value; }
        get { return this.fname; }
    }
    public string SNAME
    {
        set { this.sname = value; }
        get { return this.sname; }
    }
    #endregion

    #region Methods
    public void getDetails()
    {
        Console.WriteLine($" Id : {id}, Name : {fname} {sname}");
    }
    #endregion
}


public class _48_Types_TypeMembers_Region
{
    public static void Main()
    {
        _48_Employee emp = new _48_Employee() { FNAME = "Khushhal", SNAME = "Singh", ID = 101 };
        emp.getDetails();
    }
}

