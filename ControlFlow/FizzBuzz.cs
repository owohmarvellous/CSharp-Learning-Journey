namespace MyApp.ControlFlow;

public class FizzBuzz
{
    public static void Run()
    {
        string note =
        """
    ===============================
    WELCOME TO THE FIZZBUZZ APP 
    ===============================
    ==== HOW TO USE ====
    ====  ENTER A NUMBER BETWEEN 1 AND 20.
    ==== IT'LL PRINT FIZZ IF THE NUMBER IS DIVISIBLE BY 3.
    ==== THEN PRINT BUZZ IF IT IS DIVISIBLE BY 5.
    ==== THEN FIZZBUZZ IF DIVISIBLE BY BOTH.
    ==== ELSE IT WILL PRINT THE NUMBER.
    """;
        Console.WriteLine(note);
        Console.WriteLine("hit any key to continue: ");
        Console.ReadKey(true);
        Console.Write("Enter a number: ");
        string? myNumber = Console.ReadLine();
        int number = Convert.ToInt32(myNumber);

        if (number > 20)
        {
            Console.WriteLine("The number must not be higher tham 20");

        }
        else if (number % 3 == 0 && number % 5 != 0)
        {
            Console.WriteLine("FIZZ");
        }
        else if (number % 5 == 0 && number % 3 != 0)
        {
            Console.WriteLine("BUZZ");
        }
        else if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("FIZZBUZZ");
        }
        else if (number % 3 != 0 && number % 5 != 0)
        {
            Console.WriteLine($"The number is: {number}");
        }
        else
        {
            Console.Write("Press 'R' to try again or anyother key to exit:");
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.WriteLine();

            if (key.Key == ConsoleKey.R)
            {
                FizzBuzz.Run(); // calls it's self again
            }
            else
            {
                Console.WriteLine("Exiting Program");
                Environment.Exit(0); // Ends the program
            }

        }

    }
};