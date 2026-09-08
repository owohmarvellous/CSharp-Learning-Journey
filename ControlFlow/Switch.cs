namespace MyApp.ControlFlow;

public class Switch
{
    public static void Run()
    {
        // First Excercise
        Console.Write("Pick a number from 1 to 7:");
        string? num = Console.ReadLine();
        int day = Convert.ToInt32(num);

        switch (day) // Checks for each day with respect to the assigned number of (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;

            default:
                Console.WriteLine("Invalid day"); // Is displayed if a number higher than 7 is entered
                break;
        }

        // Second Excercise
        // This especially useful when doing authentication and authorization
        int option = 10;
        switch (option)
        {
            case 1:
                Console.WriteLine("Create account");
                break;

            case 2:
                Console.WriteLine("Login");
                break;

            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
};
