namespace LINQ;

public class Employeer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public string Department { get; set; } = string.Empty;
    public void Run()
    {
        List<Employeer> employees = new()
        {
            new Employeer() { Id = 1, Name = "John", Salary = 50000 , Department = "IT"},
            new Employeer() { Id = 2, Name = "Jane", Salary = 60000, Department = "HR"},
            new Employeer() { Id = 3, Name = "Bob", Salary = 55000 ,Department = "Finance"},
            new Employeer() { Id = 4, Name = "Alice", Salary = 70000, Department = "IT"},
            new Employeer() { Id = 5, Name = "Charlie", Salary = 65000, Department = "Legal"},
            new Employeer() { Id = 6, Name = "David", Salary = 80000, Department = "Management"},
        };
        //  Find employees with salary greater than 60000
        var highEarners = employees.Where(e => e.Salary > 60000);

        foreach (var employee in highEarners)
        {
            Console.WriteLine($"High Earner: {employee.Name}, Salary: {employee.Salary}");
        }

        // Get ony the names of employees in the IT department
        var itEmployees = employees.Where(e => e.Department == "IT").Select(e => e.Name);
        Console.WriteLine("Employees in IT Department:");
        foreach (var name in itEmployees)
        {
            Console.WriteLine(name);
        }

        // Sort employees by salary in descending order
        var sortedEmployees = employees.OrderByDescending(e => e.Salary);
        Console.WriteLine("Employees sorted by salary (descending):");

        foreach (var employee in sortedEmployees)
        {
            Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}");
        }

        // Find the Hughest paid employee
        var highestPaidEmployee = employees.OrderByDescending(e => e.Salary).FirstOrDefault();
        if (highestPaidEmployee != null)
        {
            Console.WriteLine($"Highest Paid Employee: {highestPaidEmployee.Name}, Salary: {highestPaidEmployee.Salary}");
        }

        // Calculate the average salary of employees
        var averageSalary = employees.Average(e => e.Salary);
        Console.WriteLine($"Average Salary of Employees: {averageSalary}");
        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}");
        }

        // Check if an employee earns more than 80000
        bool hasHighEarner = employees.Any(e => e.Salary > 80000);
        Console.WriteLine($"Is there any employee earning more than 80000? {hasHighEarner}");
        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}");
        }

        // Check if all employees earn at least 50000
        bool allAboveThreshold = employees.All(e => e.Salary >= 50000);
        Console.WriteLine($"Do all employees earn at least 50000? {allAboveThreshold}");
        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}