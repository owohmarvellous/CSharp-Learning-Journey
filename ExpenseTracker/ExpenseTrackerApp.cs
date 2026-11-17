
using MyApp.ExpenseTracker.Services;
using MyApp.ExpenseTracker.Models;

namespace MyApp.ExpenseTracker;

public class ExpenseTrackerApp
{
    private readonly ExpenseService _expenseService;

    public ExpenseTrackerApp(ExpenseService expenseService)
    {
        _expenseService = expenseService;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\n========== EXPENSE TRACKER ==========");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View All Expenses");
            Console.WriteLine("3. Get Total Expenses");
            Console.WriteLine("4. Search Expenses");
            Console.WriteLine("5. Filter by Category");
            Console.WriteLine("6. Delete Expense");
            Console.WriteLine("7. Exit");

            Console.Write("Choose an option: ");
            string? choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        AddExpense();
                        break;

                    case "2":
                        ViewExpenses();
                        break;

                    case "3":
                        decimal total = _expenseService.GetTotalExpenses();
                        Console.WriteLine($"Total Expenses: ₦{total:N2}");
                        break;

                    case "4":
                        SearchExpenses();
                        break;

                    case "5":
                        FilterByCategory();
                        break;

                    case "6":
                        DeleteExpense();
                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    private void AddExpense()
    {
        Console.Write("Enter description: ");
        string description = Console.ReadLine() ?? "";

        Console.Write("Enter category: ");
        string category = Console.ReadLine() ?? "";

        Console.Write("Enter amount: ");

        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        _expenseService.AddExpense(description, category, amount);

        Console.WriteLine("Expense added successfully!");
    }

    private void ViewExpenses()
    {
        var expenses = _expenseService.GetAllExpenses();

        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
            return;
        }

        foreach (var expense in expenses)
        {
            Console.WriteLine(
                $"ID: {expense.Id} | " +
                $"{expense.Description} | " +
                $"{expense.Category} | " +
                $"₦{expense.Amount:N2} | " +
                $"{expense.Date:dd/MM/yyyy}"
            );
        }
    }

    private void SearchExpenses()
    {
        Console.Write("Enter search keyword: ");
        string keyword = Console.ReadLine() ?? "";

        var results = _expenseService.SearchExpenses(keyword);

        if (!results.Any())
        {
            Console.WriteLine("No matching expenses found.");
            return;
        }

        foreach (var expense in results)
        {
            Console.WriteLine(
                $"{expense.Description}: ₦{expense.Amount:N2}"
            );
        }
    }

    private void FilterByCategory()
    {
        Console.Write("Enter category: ");
        string category = Console.ReadLine() ?? "";

        var results = _expenseService.GetExpensesByCategory(category);

        if (!results.Any())
        {
            Console.WriteLine("No expenses found in this category.");
            return;
        }

        foreach (var expense in results)
        {
            Console.WriteLine(
                $"{expense.Description}: ₦{expense.Amount:N2}"
            );
        }
    }

    private void DeleteExpense()
    {
        Console.Write("Enter expense ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        bool deleted = _expenseService.DeleteExpense(id);

        Console.WriteLine(
            deleted ? "Expense deleted successfully." : "Expense not found."
        );
    }
}
