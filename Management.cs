namespace ConsoleApp79;

public static class Management
{
    private static List<Employee> _employees = new ();

    public static void Addemployee(int id, int salary)
    {
        var employee = new Employee(id, salary);
        _employees.Add(employee);
        employee.PrintDetails();
        
    }

    public static void AddManager(int id ,int salary, string department)
    {
        var manager = new Manager(id, salary, department);
        _employees.Add(manager);
        manager.PrintDetails();
    }

    public static List<Employee> GetUsers()
    {
        return _employees;
    }

    
    
}