namespace Nullable;

public class User
{
    public string Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }

    public void DisplayContact()
    {
        Name = "Micheal";
        Email = null;
        // Email ??= "Not Provided"; // This tells Csharp to return Not Provided if the Email is null.
        PhoneNumber = null;
        PhoneNumber ??= "Not Provided";

        // if (Email is not null || PhoneNumber is not null)
        // {
        //     Console.WriteLine(Name.Length);
        //     Console.WriteLine(Email?.Length);
        //     Console.WriteLine(PhoneNumber.Length);
        // }

        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email ?? "Not Provided"}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");

    }
}