using System.Globalization;
using System.Linq;
using MyApp.Basics;
namespace LINQ;

public class BasicLinq
{
    public void Run()
    {
        List<int> numbers = new List<int>
        {
            10,45,33,15,17,90
        };

        // Where() filters a collection.
        var result = numbers.Where(number => number > 20);
        Console.WriteLine("The Numbers");
        foreach (int number in result)
        {

            Console.WriteLine(number);
        }

        var evenNumbers = numbers.Where(number => number % 2 == 0);
        Console.WriteLine("The Even Numbers");
        foreach (int number in evenNumbers)
        {

            Console.WriteLine(number);
        }

        // Select() is used when you want to transform each item.
        var squaredNumbers = numbers.Select(number => number * number);
        Console.WriteLine("The Squareroot Of The Numbers");
        foreach (int number in squaredNumbers)
        {

            Console.WriteLine(number);
        }

        var sortedNumbers = numbers.OrderByDescending(number => number);
        Console.WriteLine("Ordered By Descending Order");
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }

        //  First() returns the first item
        //  you must note that First() throws an exception if nothing is found
        Console.WriteLine("The first Number > 50");
        int first = numbers.First(number => number > 50);
        Console.WriteLine(first);

        // FirstOrDefault() is like First() only that it returns a defualt number instead of an exception when nothing is found.
        Console.WriteLine("This is the result for FirstOrDefault");
        int num = numbers.FirstOrDefault(number => number > 550);
        Console.WriteLine(num);

        // Any() asks if atleast one item meets the specified condition and it returns a bool.
        Console.WriteLine("The result for using Any()");
        bool hasLargeNumber = numbers.Any(number => number > 100);
        Console.WriteLine(hasLargeNumber);

        if (numbers.Any(number => number > 40))
        {
            Console.WriteLine("There is a number above 40");
        }

        // Count() returns the total number of items.
        Console.WriteLine("THis the result for Count()");
        int total = numbers.Count();
        Console.WriteLine(total);

        int eventCount = numbers.Count(number => number % 2 == 0);
        Console.WriteLine(eventCount);
    }

}

