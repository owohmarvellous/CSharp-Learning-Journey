namespace MyApp.ControlFlow;

public class ElseIf
{
    public static void Run()
    {
        int age = 16;
        if (age >= 18)
        {
            Console.WriteLine("You're an Adult");
        }
        else
        {
            Console.WriteLine("You're a Minor");
        }
        // Multiple Conditions...
        int personAge = 13;
        if (personAge <= 13)
        {
            Console.WriteLine("You're a Child");
        }
        else if (personAge < 18)
        {
            Console.WriteLine("You're a Teenager");
        }
        else
        {
            Console.WriteLine("You're an Adult");
        }

        // Combining Coniditions using operators
        int studentAge = 33;
        bool hasId = true;
        if (studentAge >= 18 && hasId) // Both Conditions must be true.
        {
            Console.WriteLine("Access granted");
        }
        else
        {
            Console.WriteLine("Access Denied... you must be 18 and have your ID");
        }
        bool isStudent = false;
        bool isStaff = true;
        if (isStudent || isStaff) // One must be true
        {
            Console.WriteLine("access Granted");
        }


        // Tenary Operators
        int myAge = 22;
        string result = myAge >= 18 ? "Adult" : "Minor";
        Console.WriteLine(result);
    }
};