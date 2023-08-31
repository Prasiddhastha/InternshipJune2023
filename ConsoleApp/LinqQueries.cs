using Newtonsoft.Json;

namespace ConsoleApp;

public class LinqQueries
{
    public LinqQueries()
    {
        Console.WriteLine($"{new string('-', 50)} LINQ {new string('-', 50)}");
        Console.WriteLine("LINQ (Language Integrated Query) is a powerful feature in C# that allows you to query and manipulate data ");
        Console.WriteLine("from different sources using a consistent syntax, making it easier to work with collections, databases, ");
        Console.WriteLine("and more.");
        Console.WriteLine(new string('-', 106));
        Console.WriteLine("");
    }

    public void FilteringElements()
    {
        ShowHeader(1, "Filter Even Numbers from the list", 46);

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        ShowQuestion("Given list of integers", numbers);

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        ShowResult(evenNumbers);
    }

    public void SortingElements()
    {
        ShowHeader(2, "Sort the names list", 32);

        List<string> names = new List<string> { "Alice", "Eve", "David", "Bob", "Charlie" };

        ShowQuestion("Given list of names", names);

        var sortedNames = names.OrderBy(name => name);

        ShowResult(sortedNames);
    }

    public void SelectSpecifics()
    {
        ShowHeader(3, "Select name from the list", 38);

        List<LinqPerson> people = new List<LinqPerson>
        {
            new LinqPerson { Name = "Alice", Age = 25 },
            new LinqPerson { Name = "Bob", Age = 30 },
            new LinqPerson { Name = "Charlie", Age = 35 }
        };

        ShowQuestion("Given list of people", people, true);

        var names = people.Select(person => person.Age);

        ShowResult(names);
    }

    public void Aggregation()
    {
        ShowHeader(4, "Sum the numbers in the list", 40);

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        ShowQuestion("Given list", numbers);

        var sum = numbers.Sum();

        ShowResult(sum);
    }

    public void JoinLists()
    {
        ShowHeader(5, "Join two lists based on a condition", 48);

        List<LinqProduct> products = new List<LinqProduct>
        {
            new LinqProduct { Name = "Apple", Price = 1 },
            new LinqProduct { Name = "Banana", Price = 2 },
            new LinqProduct { Name = "Orange", Price = 3 }
        };

        ShowQuestion("Given list of Products", products, true);

        List<string> fruitNames = new List<string> { "Apple", "Banana", "Cherry" };

        ShowQuestion("Given list of Fruits", fruitNames, true);

        var matchingProducts = products.Join(fruitNames, p => p.Name, name => name, (p, name) => p);

        ShowResult(matchingProducts, true);
    }

    public void DistinctValues()
    {
        ShowHeader(6, "Show Distinct values out of the list", 50);

        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        ShowQuestion("Given list of integers", numbers);

        List<int> distinctNumbers = numbers.Distinct().ToList();

        ShowResult(distinctNumbers);
    }

    public void SkipMe(int skipCount)
    {
        ShowHeader(7, $"Skip {skipCount} elements", 28);

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        ShowQuestion("Given list of numbers", numbers);

        List<int> skippedNumbers = numbers.Skip(skipCount).ToList();

        ShowResult(skippedNumbers);
    }

    public void TakeMe(int takeCount)
    {
        ShowHeader(8, $"Take {takeCount} elements", 28);

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        ShowQuestion("Given list of numbers", numbers);

        List<int> takenNumbers = numbers.Take(takeCount).ToList();

        ShowResult(takenNumbers);
    }

    public void CountMe()
    {
        ShowHeader(9, "Count the number of items", 38);

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        ShowQuestion("Given the list of integers", numbers);

        int count = numbers.Count();

        ShowResult(count);
    }

    public void AmThere()
    {
        ShowHeader(10, "Does Mary exist in the list?", 42);

        List<string> names = new List<string> { "John", "Mary", "David" };

        ShowQuestion("Given list of names", names);

        bool containsMary = names.Contains("Mary");

        ShowResult(containsMary);
    }

    public void FirstAndLast()
    {
        ShowHeader(11, "Show First and Last item from the list", 52);

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        ShowQuestion("Given list of numbers", numbers);

        int firstNumber = numbers.FirstOrDefault();

        int lastNumber = numbers.LastOrDefault();

        ShowResult(new { firstNumber, lastNumber }, true);
    }

    public void FindMax()
    {
        ShowHeader(12, "Find Max number from the list", 44);

        List<int> numbers = new List<int> { 1, 5, 3, 2, 4 };

        ShowQuestion("Given the list of integers", numbers);

        int maxNumber = numbers.Max();

        ShowResult(maxNumber);
    }

    #region Private Methods

    private void ShowHeader(int example, string title, int dash)
    {
        Console.WriteLine($"\n{new string('-', dash)}");
        Console.WriteLine($" Example {example}: {title}");
        Console.WriteLine($"{new string('-', dash)}");
    }

    private void ShowQuestion(string title, dynamic data, bool isFormatted = false)
    {
        Console.Write($"\n{title}: ");
        if (isFormatted)
            Console.WriteLine($"\n{JsonConvert.SerializeObject(data, Formatting.Indented)}");
        else
            Console.WriteLine(JsonConvert.SerializeObject(data));
    }

    private void ShowResult(dynamic data, bool isFormmatted = false)
    {
        if (isFormmatted)
            Console.WriteLine($"\nResult: \n{JsonConvert.SerializeObject(data, Formatting.Indented)}");
        else
            Console.WriteLine($"Result: {JsonConvert.SerializeObject(data)}");
    } 

    #endregion
}
