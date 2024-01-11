namespace ConsoleApp79;

public class Employee
{
    public Employee(int id, int salary)
    {
        EmployeeId = id;
        Salary = salary;
    }
    public int EmployeeId { get; set; }
    public int Salary { get; set; }

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Employee Id :{EmployeeId} - salary:{Salary} "  );
    }
}

public class Manager : Employee
{
    
    public string Department { get; set; }

    public Manager(int id, int salary,string department) : base(id, salary)
    {
        Department = department;
    }

    public  void PrintDetails()
    {
        Console.WriteLine($"Manager Id:{EmployeeId} - Salary:{Salary} - Department :{Department}");
        
    }
}