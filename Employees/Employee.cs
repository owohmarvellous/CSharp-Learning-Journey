using System.Security.Cryptography.X509Certificates;

namespace Employees;

public class Employee
{
    // The Employee Properties
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public string? Department { get; set; }
    public decimal Salary { get; set; }

    // The Employee Constructor.
    public Employee(int id, string employeename, string? department, decimal salary)
    {
        Id = id;
        EmployeeName = employeename;
        Department = department;
        Salary = salary;

    }

    // This Method displays the Employee Information.
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id} | EmployeeName: {EmployeeName} | Department: {Department ?? "Not Assigned"} | Salary: {Salary}");
    }


}