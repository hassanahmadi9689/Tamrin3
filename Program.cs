// See https://aka.ms/new-console-template for more information


using ConsoleApp79;

var exit = false;
while (!exit)
{
    var Option = GetNumberFromUser("choose option:\n" +
                                   "1.Add employee\n" +
                                   "2.Add Manager\n" +
                                   "3.Show lis of users whit position");
    switch (Option)
    {
        case 1:
        {
            var employeeId = GetNumberFromUser("enter ID");
            var salary = GetNumberFromUser("enter salary");
            Management.Addemployee(employeeId,salary);
            break;
        }
        case 2:
        {
            var employeeId = GetNumberFromUser("enter ID");
            var salary = GetNumberFromUser("enter salary");
            var department = GetValidStringFromUser("enter department");
            Management.AddManager(employeeId,salary,department);
            break;
        }
        case 3:
        {
            foreach (var employee in Management.GetUsers())
            {
                Console.WriteLine($"{employee.EmployeeId} - {employee.Salary} ");
            }
            
            break;
        }
    
    }
}



static int GetNumberFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    int number;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            int.TryParse(Console.ReadLine(), out number);
    } while (!resultTryParseFirstNumber );

    return number;
}
static string GetValidStringFromUser(string message)
{
    bool tryparse = false;
    string? value;
    do
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
          
    } while ( string.IsNullOrWhiteSpace(value)   );
 
    return value;
}