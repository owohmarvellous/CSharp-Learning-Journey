namespace Async;

public class BasicAsync
{
    public async Task Run()
    {

        // Task
        // A Task represents an asynchronous operation that may complete in the future.
        Task operation = Task.Delay(2000);

        static async Task SayHelloAsync()
        {
            Console.WriteLine("Hello!");
            await Task.Delay(2000);
            Console.WriteLine("Welcome to C#");

        }

        static async Task DisplayMessageAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Operation completed !");
        }

        await DisplayMessageAsync();


        static async Task<int> GetNumberAsync()
        {
            await Task.Delay(1000);
            return 100;
        }

        int number = await GetNumberAsync();
        Console.WriteLine(number);

        static async Task DownloadDataAsync()
        {
            await Task.Delay(3000);
            Console.WriteLine("Download Completed");
        }
        await DownloadDataAsync();

        static async Task<string> GetEmployeeCount()
        {
            await Task.Delay(2000);
            return "Total number of Employee's:30";
        }

        string employeeCount = await GetEmployeeCount();
        Console.WriteLine(employeeCount);
        static async Task GetEmployeeDataAsync()
        {
            Console.WriteLine("Starting...");
            Console.WriteLine("Writing...");
            Console.WriteLine("Finished Writing...");
            Console.WriteLine("Program Continues...");

        }
        await GetEmployeeDataAsync();
    }
}