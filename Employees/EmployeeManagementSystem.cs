using System.Diagnostics;

namespace Employees;

public class EmployeeManagentSystem
{
    // 
    private readonly List<Employee> employees = new();

    // The Run() is the entry point of the program
    public void Run()
    {
        while (true)
        {
            Console.WriteLine("====== EMPLOYEE MANAGEMENT SYSTEM ======");

            Console.WriteLine("1. Add Employee.");
            Console.WriteLine("2. View Employee.");
            Console.WriteLine("3. Search Employee.");
            Console.WriteLine("4. View Highest Paid Employee.");
            Console.WriteLine("5. View Employees By Department.");
            Console.WriteLine("6. Exit.");

            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    DisplayEmployees();
                    break;
                case "3":
                    SearchEmployee();
                    break;
                case "4":
                    ViewHighestPaidEmployee();
                    break;
                case "5":
                    ViewEmployeesByDepartment();
                    break;
                case "6":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }

    }

    // The AddEmployee() method is responsible for adding a new employee to the system. It prompts the user for employee details, creates an Employee object, and adds it to the employees list.
    private void AddEmployee()
    {
        try
        {
            Console.Write("Enter Employee ID:");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Employee Name: ");
            string employeename = Console.ReadLine()!;

            Console.Write("Enter Employee Department: ");
            string? department = Console.ReadLine()!;

            Console.Write("Enter Employee Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine()!);

            //   Initializing the Constructor.
            Employee employee = new Employee(id, employeename, department, salary);

            // Calls the Add
            employees.Add(employee);

            Console.WriteLine("Employee added successfully!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter valid data.");
        }


    }

    // The DisplayEmployees() method is responsible for displaying the list of employees in the system. It checks if there are any employees in the list and displays their information using the DisplayInfo() method of the Employee class.
    private void DisplayEmployees()
    {
        if (!employees.Any())
        {
            Console.WriteLine("No employees found.");
            return;
        }

        Console.WriteLine("Employee List:");
        foreach (Employee employee in employees)
        {
            employee.DisplayInfo();
        }
    }

    // The SearchEmployee() method is responsible for searching for an employee by their ID. It prompts the user to enter an employee ID, searches for the employee in the employees list using LINQ, and displays the employee's information if found. If the employee is not found, it displays a message indicating that the employee was not found.
    private void SearchEmployee()
    {
        Console.Write("Enter Employee ID to search: ");
        int id = int.Parse(Console.ReadLine()!);

        // Search for the employee with the specified ID in the employees list
        Employee? employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee != null)
        {
            Console.WriteLine("Employee Found:");
            employee.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    // The ViewEmployeesByDepartment() method is responsible for displaying the list of employees grouped by their department. It checks if there are any employees in the list and groups them by department using LINQ. It then displays the employees in each department.
    private void ViewHighestPaidEmployee()
    {
        if (!employees.Any())
        {
            Console.WriteLine("No employees found.");
            return;
        }

        // Find the employee with the highest salary
        Employee highestPaidEmployee = employees.OrderByDescending(e => e.Salary).First();
        Console.WriteLine("Highest Paid Employee:");
        highestPaidEmployee.DisplayInfo();
    }

    private void ViewEmployeesByDepartment()
    {
        if (!employees.Any())
        {
            Console.WriteLine("No employees found.");
            return;
        }

        // Group employees by department
        var employeesByDepartment = employees.GroupBy(e => e.Department);

        Console.WriteLine("Employees By Department:");
        foreach (var departmentGroup in employeesByDepartment)
        {
            Console.WriteLine($"Department: {departmentGroup.Key ?? "Not Assigned"}");
            foreach (Employee employee in departmentGroup)
            {
                employee.DisplayInfo();
            }
            Console.WriteLine();
        }
    }
}