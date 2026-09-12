namespace Collections;

public class Arrays
{
    public static void Run()
    {
        // int[] score = new int[5];

        // score[0] = 5;
        // score[1] = 5;
        // score[2] = 5;
        // score[3] = 5;
        // score[4] = 5;

        int[] score = { 5, 6, 7, 8, 9 };
        Console.WriteLine(score);

        // Using Arrays with foreach loop
        int[] number = { 50, 60, 70, 80, 90 };

        foreach (int numbers in number)
        {
            Console.WriteLine(numbers);
        }

        // The .Length property shows you how many items are in an Array
        int[] values = { 44, 55, 66, 88, 99 };
        Console.WriteLine(values.Length);

        //  Using for loops for the .Length property
        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine(values[i]);
        }

        // Arrays have a fixed size so we can't just add values like that hence we use List<T>
        List<int> value = new List<int>();
        value.Add(13);
        value.Add(300);
        value.Add(76);

        Console.WriteLine(value[0]);

        foreach (int num in value)
        {
            Console.WriteLine(value);
        }

        // We can remove a List using .RemoveAt(index of the item)
        value.RemoveAt(1);

        // The .Count property checks the number of items in a list<T>
        Console.WriteLine(value.Count);

        //  How to search a List
        if (value.Contains(44))
        {
            Console.WriteLine("The value is found ");
        }
        else
        {
            Console.WriteLine("The value is not there ");
        }

        //    Dictonary<TKey, TValue>
        // Dictionary = key -> value

        Dictionary<string, int> studentScores = new Dictionary<string, int>();
        studentScores["James"] = 64;
        studentScores["Victor"] = 81;
        studentScores["Louis"] = 71;

        // Getting a value from the Dictionsry
        Console.WriteLine(studentScores["James"]);

        // The .Add() method for Dictionaries
        studentScores.Add("John", 66);

        Console.WriteLine(studentScores["Louis"]);

        // Checking if a key exists
        if (studentScores.ContainsKey("Victor"))
        {
            Console.WriteLine(studentScores["James"]);
        }

        // HasSet<T>
        // It is useful when you want to get a collection of unique values

        HashSet<string> names = new HashSet<string>();

        Console.WriteLine(names.Add("Jude"));
        Console.WriteLine(names.Add("Jude"));
        Console.WriteLine(names.Add("Mike"));
        // HashSet does not allow duplicate values

        string[] states = { "Enugu", "Anambra", "Ebonyi", "Abia" };

        foreach (string state in states)
        {
            Console.WriteLine(state);
        }

    }
}