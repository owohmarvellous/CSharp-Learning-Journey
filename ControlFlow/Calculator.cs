namespace MyApp.ControlFlow;

public class Calculator
{
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
        Console.WriteLine("hit any key to continue: ");
        Console.ReadKey(true);
        Console.Write("Enter firstNmber:");
        string? num = Console.ReadLine();
        int firstNumber = Convert.ToInt32(num);

        Console.Write("Enter secondNmber:");
        string? num2 = Console.ReadLine();
        int secondNumber = Convert.ToInt32(num2);

        Console.Write("Choose an operation '+', '-' ,'*' ,'/' ,'%':");
        string? operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Console.WriteLine(firstNumber + secondNumber);
                break;

            case "-":
                Console.WriteLine(firstNumber - secondNumber);
                break;

            case "*":
                Console.WriteLine(firstNumber * secondNumber);
                break;

            case "/":
                // it divides if the firstNumber is greater and performs modulud is its lesser.
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine(firstNumber / secondNumber);
                }
                else
                {
                    Console.WriteLine(firstNumber % secondNumber);
                }
                break;
        }



    }
};