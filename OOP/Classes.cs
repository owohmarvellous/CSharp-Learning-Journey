using System.Security.Cryptography.X509Certificates;

namespace OOP;

public class Student
{
    public string? Name;
    public int Age;
    public int Score;
    // This is a method in a class
    public void Introduce()
    {
        Console.WriteLine($"My name is {Name} and i am {Age} years old, My score is {Score}");
    }

};

// Another class

public class BankAccount
{
    public string? AccountName;
    public decimal Balance;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
    public void DisplayBalance()
    {
        Console.WriteLine($"AccountName:{AccountName} : Balance:{Balance}");
    }
}

