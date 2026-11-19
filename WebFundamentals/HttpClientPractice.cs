
using System.Net.Http.Json;

public class HttpClientPractice
{
    private readonly HttpClient _httpClient;

    public HttpClientPractice(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task RunAsync()
    {
        Console.WriteLine("HTTP Client Practice");

        // Example GET request
        await GetExampleAsync();

        // Example POST request
        await PostExampleAsync();
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
}