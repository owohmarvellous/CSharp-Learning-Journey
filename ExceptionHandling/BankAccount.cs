namespace ExceptionHandling;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }
    public decimal GetBalance()
    {
        return balance;
    }
    public void Deposit()
    {
        Console.Write("Enter Amount to deposit: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            throw new ArgumentException("Please enter a valid amount.");
        }

        if (amount <= 0)
        {
            throw new ArgumentException("The amount must be greater than 0.");
        }
        balance += amount;
        Console.WriteLine($" #{amount:N2} deposited successfully.");
    }
    public void Withdraw()
    {
        Console.Write("Enter Amount to withdraw: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            throw new ArgumentException("Please enter a valid amount.");
        }

        if (amount <= 0)
        {
            throw new ArgumentException("The amount must be greater than 0.");
        }
        else if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds. You cannot withdraw more than your balance.");
        }

        balance -= amount;
        Console.WriteLine($" #{amount:N2} withdrawn successfully.");
    }





}