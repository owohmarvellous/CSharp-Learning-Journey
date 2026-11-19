using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class HttpMethodsPractice
{
    private readonly HttpClient _httpClient;

    public HttpMethodsPractice(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task RunAsync()
    {
        Console.WriteLine("HTTP Methods Practice");

        // Example GET request
        await GetExampleAsync();

        // Example POST request
        await PostExampleAsync();

        // Example PUT request
        await PutExampleAsync();

        //   Example PATCH request
        await PatchExampleAsync();

        // Example DELETE request
        await DeleteExampleAsync();
    }

    private async Task GetExampleAsync()
    {
        Console.WriteLine("\nGET Request Example:");
        HttpResponseMessage response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
    }

    private async Task PostExampleAsync()
    {
        Console.WriteLine("\nPOST Request Example:");
        var postData = new { title = "foo", body = "bar", userId = 1 };
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync("https://jsonplaceholder.typicode.com/posts", postData);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
    }

    private async Task PutExampleAsync()
    {
        Console.WriteLine("\nPUT Request Example:");
        var putData = new { id = 1, title = "foo", body = "bar", userId = 1 };
        HttpResponseMessage response = await _httpClient.PutAsJsonAsync("https://jsonplaceholder.typicode.com/posts/1", putData);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
    }

    private async Task PatchExampleAsync()
    {
        Console.WriteLine("\nPATCH Request Example:");
        var patchData = new { title = "foo" };
        HttpResponseMessage response = await _httpClient.PatchAsync("https://jsonplaceholder.typicode.com/posts/1", new StringContent(JsonSerializer.Serialize(patchData), Encoding.UTF8, "application/json"));
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
    }

    private async Task DeleteExampleAsync()
    {
        Console.WriteLine("\nDELETE Request Example:");
        HttpResponseMessage response = await _httpClient.DeleteAsync("https://jsonplaceholder.typicode.com/posts/1");
        response.EnsureSuccessStatusCode();
        Console.WriteLine("Post deleted successfully.");
    }

}