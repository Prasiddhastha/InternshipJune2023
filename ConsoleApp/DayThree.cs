namespace ConsoleApp;

public static class DayThree
{
    /// <summary>
    /// Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
    /// </summary>
    /// <param name="number">Input Month Number</param>
    public static void GetMonth(int number)
    {
        // using switch expression
        var result = number switch
        {
            1 => "January",
            2 => "February",
            3 => "March",
            4 => "April",
            5 => "May",
            6 => "June",
            7 => "July",
            8 => "August",
            9 => "September",
            10 => "October",
            11 => "November",
            12 => "December",
            _ => "Not a Valid Month"
        };

        Console.WriteLine($"GetMonth({number}) = {result}");
    }
}
