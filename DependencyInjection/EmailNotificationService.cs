namespace DependencyInjection;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Email notification: {message}");
    }
}