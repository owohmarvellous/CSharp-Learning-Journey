using System;
using System.Collections.Generic;
using System.Linq;

public class Expense
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}

public class ExpenseTracker
{
    private readonly List<Expense> expenses = new List<Expense>();

    private int nextId = 1;

    public void AddExpense(
        string description,
        string category,
        decimal amount)
    {
        if (string.IsNullOrWhiteSpace(description) ||
            string.IsNullOrWhiteSpace(category))
        {
            Console.WriteLine("Description and category are required.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Amount must be greater than zero.");
            return;
        }

        Expense expense = new Expense
        {
            Id = nextId++,
            Description = description,
            Category = category,
            Amount = amount,
            Date = DateTime.Now
        };

        expenses.Add(expense);

        Console.WriteLine("Expense added successfully.");
    }

    public void ViewExpenses()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses recorded.");
            return;
        }

        foreach (Expense expense in expenses)
        {
            Console.WriteLine(
                $"ID: {expense.Id} | " +
                $"Description: {expense.Description} | " +
                $"Category: {expense.Category} | " +
                $"Amount: ₦{expense.Amount:N2} | " +
                $"Date: {expense.Date:dd/MM/yyyy}"
            );
        }
    }

    public void CalculateTotal()
    {
        decimal total = expenses.Sum(e => e.Amount);

        Console.WriteLine($"Total expenses: ₦{total:N2}");
    }

    public void SearchExpense(string keyword)
    {
        var results = expenses.Where(e =>
            e.Description.Contains(
                keyword,
                StringComparison.OrdinalIgnoreCase
            ));

        if (!results.Any())
        {
            Console.WriteLine("No matching expenses found.");
            return;
        }

        foreach (Expense expense in results)
        {
            Console.WriteLine(
                $"{expense.Description}: ₦{expense.Amount:N2}"
            );
        }
    }

    public void FilterByCategory(string category)
    {
        var results = expenses.Where(e =>
            e.Category.Equals(
                category,
                StringComparison.OrdinalIgnoreCase
            ));

        if (!results.Any())
        {
            Console.WriteLine("No expenses in this category.");
            return;
        }

        foreach (Expense expense in results)
        {
            Console.WriteLine(
                $"{expense.Description}: ₦{expense.Amount:N2}"
            );
        }
    }

    public void DeleteExpense(int id)
    {
        Expense expense = expenses.FirstOrDefault(e => e.Id == id);

        if (expense == null)
        {
            Console.WriteLine("Expense not found.");
            return;
        }

        expenses.Remove(expense);

        Console.WriteLine("Expense deleted successfully.");
    }
}