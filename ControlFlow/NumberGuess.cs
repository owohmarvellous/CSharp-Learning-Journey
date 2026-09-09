namespace MyApp.NumberGuess;

public class NumberGuess
{
    public static void WhileGuess()
    {
        int secretNumber = 4;
        int guess;
        Console.Write("Enter a number between 1 and 10: ");
        guess = Convert.ToInt32(Console.ReadLine());

        while (guess != secretNumber)
        {
            if (guess > secretNumber)
            {

                Console.WriteLine("WRONG THE GUESS IS TOO HIGH!");

            }
            else
            {
                Console.WriteLine("TWRONG THE GUESS IS TOO LOW!");
            }
            Console.Write("Enter a number between 1 and 10: ");
            guess = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("CONGRATS...! YOU GOT THE NUMBER");

    }
    public static void ForGuess()
    {
        int hiddenNumber = 4;
        int Guess;
        Console.Write("Enter a number between 1 and 10: ");
        Guess = Convert.ToInt32(Console.ReadLine());

        for (; Guess != hiddenNumber;)
        {
            Console.WriteLine("Wrong try another number");
            Console.Write("Enter a number between 1 and 10: ");
            Guess = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("Nicee you got the right answer");
    }
};