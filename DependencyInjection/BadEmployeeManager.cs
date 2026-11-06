namespace DependencyInjection;

public class EmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class BadEmployeeManager
{
    private EmailService _emailservice = new EmailService();

    public void NotifyEmployee()
    {
        _emailservice.SendEmail("Welcome to the company");
    }
}