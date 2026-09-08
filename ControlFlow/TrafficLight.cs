namespace Myapp.ControFlow;

public class TrafficLight
{
    public static void Shine()
    {
        // Takes the color you enter
        Console.Write("Select a color: ");
        string? color = Console.ReadLine();

        // Parses the color to see which case it matches.
        switch (color)
        {
            case "Green":
                Console.WriteLine("Go!!!");
                break;

            case "Yellow":
                Console.WriteLine("GET READY TO STOP!!!");
                break;

            case "Red":
                Console.WriteLine("STOP!!!");
                break;

            default:
                // Displays this if it does'nt match any case.
                Console.WriteLine("Invalid Color");
                break;
        }
    }
};