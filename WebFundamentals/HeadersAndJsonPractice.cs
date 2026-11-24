namespace WebFundamentals;

using System.Text.Json;

public class EmployeeJson
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string Department { get; set; } = string.Empty;
    public decimal Salary { get; set; }

    public EmployeeJson()
    {
    }

    public EmployeeJson(int id, string? name, string department, decimal salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }

    public void SerializeEmployee()
    {
        // Serialize the Employee object to JSON and print it to the console
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(this, options);
        Console.WriteLine(json);
    }

    public static EmployeeJson? DeserializeEmployee(string json)
    {
        // Deserialize the JSON string back to an Employee object
        return JsonSerializer.Deserialize<EmployeeJson>(json);
    }

    public async Task InspectHeadersAsync(string url)
    {
        // Inspect the headers of an HTTP response from the specified URL
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            Console.WriteLine($"Response Headers for {url}:");
            foreach (var header in response.Headers)
            {
                Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
            }
        }
    }
}

