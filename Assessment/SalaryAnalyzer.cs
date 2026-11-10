using System;
using System.Collections.Generic;
using System.Linq;

public class SalaryAnalyzer
{
    public static void Analyze()
    {
        List<decimal> salaries = new List<decimal>
        {
            150000m,
            250000m,
            180000m,
            350000m,
            120000m,
            300000m, 
        };

        Console.WriteLine("SALARY ANALYSIS");
        Console.WriteLine("----------------------");

        decimal total = salaries.Sum();
        decimal average = salaries.Average();
        decimal highest = salaries.Max();
        decimal lowest = salaries.Min();

        int above200k = salaries.Count(s => s > 200000m);

        Console.WriteLine($"Total: ₦{total:N2}");
        Console.WriteLine($"Average: ₦{average:N2}");
        Console.WriteLine($"Highest: ₦{highest:N2}");
        Console.WriteLine($"Lowest: ₦{lowest:N2}");
        Console.WriteLine($"Above ₦200,000: {above200k}");

        Console.WriteLine("\nSalaries in descending order:");

        var sortedSalaries = salaries.OrderByDescending(s => s);

        foreach (decimal salary in sortedSalaries)
        {
            Console.WriteLine($"₦{salary:N2}");
        }
    }
}