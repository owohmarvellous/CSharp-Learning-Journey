namespace DependencyInjection;

public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"SMS notification: {message}");
    }
}