using ExpenseModel = MyApp.ExpenseTracker.Models.Expense;
using System.Text.Json;

namespace MyApp.ExpenseTracker.Services;

public class ExpenseService
{
    private readonly string _filepath = Path.Combine(Environment.CurrentDirectory, "expense.json");
    private readonly List<ExpenseModel> _expenses = new();

    private int _nextId = 1;

    public ExpenseService()
    {
        LoadExpenses();
    }
    // This method Loads Expenses.
    private void LoadExpenses()
    {
        if (!File.Exists(_filepath))
        {
            return;
        }
        try
        {
            string json = File.ReadAllText(_filepath);
            var savedExpenses =
             JsonSerializer.Deserialize<List<ExpenseModel>>(json);

            if (savedExpenses != null)
            {
                _expenses.AddRange(savedExpenses);
                _nextId = _expenses.Count > 0 ? _expenses.Max(e => e.Id) + 1 : 1;
            }
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error reading expense data: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File error: {ex.Message}");
        }
    }
    // Saves the Expenses Data.
    private void SaveExpenses()
    {
        try
        {
            string json = JsonSerializer.Serialize(
                _expenses,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            File.WriteAllText(_filepath, json);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Unable to save expenses: {ex.Message}");
        }
    }

    // Add an expense
    public void AddExpense(
        string description,
        string category,
        decimal amount)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException("Description is required.");
        }

        if (string.IsNullOrWhiteSpace(category))
        {
            throw new ArgumentException("Category is required.");
        }

        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be greater than zero.");
        }

        ExpenseModel expense = new ExpenseModel
        {
            Id = _nextId++,
            Description = description,
            Category = category,
            Amount = amount,
            Date = DateTime.Now
        };

        _expenses.Add(expense);
        SaveExpenses();
    }

    // View all expenses
    public IReadOnlyList<ExpenseModel> GetAllExpenses()
    {
        return _expenses.AsReadOnly();
    }

    // Calculate total expenses
    public decimal GetTotalExpenses()
    {
        return _expenses.Sum(e => e.Amount);
    }

    // Search expenses
    public IEnumerable<ExpenseModel> SearchExpenses(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return Enumerable.Empty<ExpenseModel>();
        }
        return _expenses.Where(e =>
            e.Description.Contains(
                keyword,
                StringComparison.OrdinalIgnoreCase));
    }

    // Filter expenses by category
    public IEnumerable<ExpenseModel> GetExpensesByCategory(string category)
    {
        return _expenses.Where(e =>
            e.Category.Equals(
                category,
                StringComparison.OrdinalIgnoreCase));
    }

    // Delete an expense
    public bool DeleteExpense(int id)
    {
        ExpenseModel? expense = _expenses.FirstOrDefault(e => e.Id == id);

        if (expense == null)
        {
            return false;
        }

        _expenses.Remove(expense);
        SaveExpenses();

        return true;
    }
}