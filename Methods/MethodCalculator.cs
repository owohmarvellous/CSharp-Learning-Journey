namespace Methods;

public class MethodCalculator
{
    // The methods below are created to handle four of the basic calculation opeartions
    public static int Add(int firstNumber = 4, int secondNumber = 4)
    {
        return firstNumber + secondNumber;
    }
    public static int Subtract(int firstNumber = 4, int secondNumber = 4)
    {
        return firstNumber - secondNumber;
    }
    public static int Multiply(int firstNumber = 4, int secondNumber = 4)
    {
        return firstNumber * secondNumber;
    }
    public static int Divide(int firstNumber = 4, int secondNumber = 4)
    {
        return firstNumber / secondNumber;
    }

    //  The code below perfoms the operation that decides which of the methods above to call
    public static void Calculate()
    {

        string note =
    """
    ===============================
    WELCOME TO THE CALCULATOR APP 
    ===============================
    ==== HOW TO USE ====
    ====  ENTER A NUMBER .
    ==== ENTER ANOTHER NUMBER.
    ==== SELECT THE OPERATION YOU WANT TO PERFORM.
    ==== THEN YOUR ANSWER WILL BE DISPLAYED.
    """;

        Console.WriteLine(note);
        Console.Write("Enter Your first number: ");
        string? num1 = Console.ReadLine();
        int firstNumber = Convert.ToInt32(num1);
        Console.Write("Enter your second number: ");
        string? num2 = Console.ReadLine();
        int secondNumber = Convert.ToInt32(num2);
        Console.Write("Choose an Operation: ");
        string? operation = Console.ReadLine();

        if (operation == "+")
        {
            Console.WriteLine(Add(firstNumber, secondNumber));
        }
        else if (operation == "-")
        {
            Console.WriteLine(Subtract(firstNumber, secondNumber));
        }
        else if (operation == "*")
        {
            Console.WriteLine(Multiply(firstNumber, secondNumber));
        }
        else if (operation == "/")
        {
            // The nested if statement prevents the code from breaking down when the user selects 0 for division.
            if (secondNumber == 0)
            {
                Console.WriteLine("You cannot divide by 0");
            }
            else
            {

                Console.WriteLine(Divide(firstNumber, secondNumber));
            }
        }
        else
        {
            Console.WriteLine("Enter a valid operation");
        }

    }
}
// THE CALCULATE() METHOD IS CALLED IN THE PROGRAM.CS FILE