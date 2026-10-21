
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Async;

public class TaskExamples
{
    // Challenge 1: Get employee data asynchronously
    public async Task<string> GetEmployeeDataAsync()
    {
        Console.WriteLine("Fetching employee data...");

        await Task.Delay(2000);

        return "Employee data retrieved successfully.";
    }

    // Challenge 2: Get department data asynchronously
    public async Task<string> GetDepartmentDataAsync()
    {
        Console.WriteLine("Fetching department data...");

        await Task.Delay(3000);

        return "Department data retrieved successfully.";
    }

    // Challenge 3: Compare sequential and concurrent execution
    public async Task CompareExecutionAsync()
    {
        Console.WriteLine("\n--- Sequential Execution ---");

        Stopwatch sequentialTimer = Stopwatch.StartNew();

        string employeeData = await GetEmployeeDataAsync();
        string departmentData = await GetDepartmentDataAsync();

        sequentialTimer.Stop();

        Console.WriteLine(employeeData);
        Console.WriteLine(departmentData);

        Console.WriteLine(
            $"Sequential time: {sequentialTimer.Elapsed.TotalSeconds:F2} seconds"
        );

        Console.WriteLine("\n--- Concurrent Execution ---");

        Stopwatch concurrentTimer = Stopwatch.StartNew();

        Task<string> employeeTask = GetEmployeeDataAsync();
        Task<string> departmentTask = GetDepartmentDataAsync();

        string[] results = await Task.WhenAll(
            employeeTask,
            departmentTask
        );

        concurrentTimer.Stop();

        foreach (string result in results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine(
            $"Concurrent time: {concurrentTimer.Elapsed.TotalSeconds:F2} seconds"
        );
    }

    // Challenge 4: Return an employee's salary
    public async Task<decimal> GetEmployeeSalaryAsync()
    {
        await Task.Delay(1000);

        return 350000m;
    }

    // Challenge 5: Use Task.WhenAny()
    public async Task RunFirstCompletedTaskAsync()
    {
        Task<string> employeeTask = GetEmployeeDataAsync();
        Task<string> departmentTask = GetDepartmentDataAsync();

        Task<string> completedTask = await Task.WhenAny(
            employeeTask,
            departmentTask
        );

        string result = await completedTask;

        Console.WriteLine("\nFirst completed task:");
        Console.WriteLine(result);

        // Wait for the remaining task as well.
        await Task.WhenAll(employeeTask, departmentTask);
    }

    // Challenge 6: Handle exceptions in asynchronous operations
    public async Task SimulateTaskExceptionAsync()
    {
        try
        {
            await Task.Run(() =>
            {
                throw new InvalidOperationException(
                    "Something went wrong while processing employee data."
                );
            });
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Task error: {ex.Message}");
        }
    }

    // Run all the examples
    public async Task RunAllExamplesAsync()
    {
        await CompareExecutionAsync();

        decimal salary = await GetEmployeeSalaryAsync();

        Console.WriteLine($"\nEmployee salary: {salary:N2}");

        await RunFirstCompletedTaskAsync();

        await SimulateTaskExceptionAsync();
    }
}