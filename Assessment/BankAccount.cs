using System;

public class BankAccount
{
    public string AccountHolder { get; private set; }

    private decimal balance;

    public BankAccount(string accountHolder, decimal startingBalance)
    {
        if (string.IsNullOrWhiteSpace(accountHolder))
        {
            throw new ArgumentException("Account holder is required.");
        }

        if (startingBalance < 0)
        {
            throw new ArgumentException("Starting balance cannot be negative.");
        }

        AccountHolder = accountHolder;
        balance = startingBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit must be greater than zero.");
        }

        balance += amount;

        Console.WriteLine($"Deposit successful: ₦{amount:N2}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal must be greater than zero.");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        balance -= amount;

        Console.WriteLine($"Withdrawal successful: ₦{amount:N2}");
    }

    public decimal GetBalance()
    {
        return balance;
    }
}