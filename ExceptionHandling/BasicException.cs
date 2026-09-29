namespace ExceptionHandling;

public class BasicException
{
    public void Run()
    {
        // The try keyword checks for the potential error in a code block
        try
        {
            Console.Write("Enter a Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number you entered is {age}");
        }
        // The catch keyword provides a nice way to handle that error instead of breaking the program.
        catch (FormatException) //FormationException is the specific type of exception we are handling here.
        {
            Console.WriteLine("You can only enter numbers. please try again");
        }
    }

    //  Multiple Exceptions

    public void Divide()
    {
        try
        {

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter a divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            int result = number / divisor;
            Console.WriteLine($"{number} divided by {divisor} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("The Input in not a number. Enter a number please");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("The Number cannot be divided by zero");
        }

        // The finally keyword
        // This is used to specify what you want to happen regardless of whether the code has an exception or not.
        finally
        {
            Console.WriteLine("The Operation only takes numbers and the divisor must be > 0");
        }

    }

    public void SetAge(int myAge)
    {
        if (myAge < 1)
        {
            throw new ArgumentException("myAge cannot be less than 1.");
        }

    }
    public void GetAge()
    {

        try
        {
            SetAge(5);
            Console.WriteLine("The age is valid.");
        }
        // The ex is refering to the previous command for throw.
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
