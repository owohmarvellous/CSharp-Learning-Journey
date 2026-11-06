namespace DependencyInjection;

public class EmployeeManager
{
    private readonly INotificationService _notificationService;

    public EmployeeManager(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void NotifyEmployee()
    {
        _notificationService.SendNotification(
            "Welcome to the company!"
        );
    }
}