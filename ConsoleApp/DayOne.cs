namespace ConsoleApp;

public class DayOne
{
    /// <summary>
    /// Create a function that takes two numbers as arguments and returns their sum.
    /// </summary>
    /// <example>
    /// Sum(3, 2) ➞ 5
    /// Sum(-3, -6) ➞ -9
    /// Sum(7, 3) ➞ 10
    /// </example>
    public void Sum(int firstNumber, int secondNumber)
    {
        var result = firstNumber + secondNumber;

        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {result}");
    }
    ///<summary>
    ///Create a function that takes a number as an argument, increments the number by +1 and returns the result.
    ///</summary>
    ///<example>
    ///Addition(0) ➞ 1
    ///Addition(9) ➞ 10
    /// Addition(-3) ➞ -2
    ///</example>
    
    public static int Addition(int number)
    {
        return number+1;
    }

    ///<summary>
    ///Create a function that takes voltage and current and returns the calculated power.
    ///</summary>
    ///<example>
    ///CircuitPower(230, 10) ➞ 2300
    ///CircuitPower(110, 3) ➞ 330
    ///CircuitPower(480, 20) ➞ 9600
    ///</example>
    public static int CirculatedPower(int voltage,int current)
    {
        return (voltage * current);
    }

    ///<summary>
    ///You are counting points for a basketball game, given the amount of 3-pointers scored and 2-pointers scored, 
    ///find the final points for the team and return that value ([2 -pointers scored, 3-pointers scored])
    ///</summary>
    ///<example>
    ///points(1, 1) ➞ 5
    ///points(7, 5) ➞ 29
    ///points(38, 8) ➞ 10
    ///</example>

    public static int Points(int scored2,int scored3)
    {
        var total = ((scored2 * 2) + (scored3 * 3));
        return total;
    }

    ///<summary>
    ///Write a function that returns the string "something" joined with a space " " and the given argument a.
    ///</summary>
    ///<example>
    ///GiveMeSomething("is better than nothing") ➞ "something is better than nothing"
    ///GiveMeSomething("Bob Jane") ➞ "something Bob Jane"
    ///GiveMeSomething("something") ➞ "something something"
    ///</example>

    public static string GiveSomething(string text)
    {
        string joined = "something" +" "+ text;
        return joined;
    }

    ///<summary>
    ///Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.
    ///</summary>
    ///<example>
    ///FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]
    ///FindMinMax([2334454, 5]) ➞ [5, 2334454]
    ///FindMinMax([1]) ➞ [1, 1]
    ///</example>
    
    public static int[] FindMinMax(int[] numArray)
    {
       
        var min= numArray[0];
        var max= numArray[0];
        for(int i = 1; i < numArray.Length; i++)
        {   
            if (numArray[i] < min)
            {
                min= numArray[i];
            }
            if (numArray[i] > max) 
            {
                max= numArray[i];
            }
        }

        var result = new int[] {min,max};
        return result;
    }

    ///<summary>
    ///Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
    ///</summary>
    ///<example>
    ///getAbsSum([2, -1, 4, 8, 10]) ➞ 25
    ///getAbsSum([-3, -4, -10, -2, -3]) ➞ 22
    ///getAbsSum([2, 4, 6, 8, 10]) ➞ 30
    ///</example>
    
    public static int GetAbSum(int[] numArray)
    {
        var sum = 0;
       for(int i = 0; i < numArray.Length; i++)
        {
            sum=sum + Math.Abs(numArray[i]);
        }
        return sum;
    }
    ///<summary>
    ///Create a function that accepts a string (of a person's first and last name) and 
    ///returns a string with the first and last name swapped.
    ///</summary>
    ///<example>
    ///NameShuffle("Donald Trump") ➞ "Trump Donald"
    ///NameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"
    ///</example>

    public static string NameShuffle(string firstName,string lastName)
    {
        return lastName +" "+ firstName;
    }

    ///<summary>
    ///Create a function to multiply all of the values in an array by the amount of values in the given array.
    ///</summary>
    ///<example>
    ///MultiplyByLength([2, 3, 1, 0]) ➞ [8, 12, 4, 0]
    ///MultiplyByLength([4, 1, 1]) ➞ ([12, 3, 3])
    ///</example>
    
    public static void MulLength(int[] number)
    {
        var nextArray = new int[number.Length];
        for (int i=0; i < number.Length; i++) 
        {
            nextArray[i] = number.Length*number[i];
        }
        Console.Write("Array Multiplied by length is: ");
        foreach (int num in nextArray)
        {
            Console.Write($"{num} ");
        }
       
    }

    ///<summary>
    ///Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.
    ///</summary>
    ///<example>
    ///lessThan100(22, 15) ➞ true //22 + 15 = 37
    ///lessThan100(83, 34) ➞ false // 83 + 34 = 117
    ///</example>

    public static bool LessThan100(int firstNumber,int secondNumber)
    {
        var sum=firstNumber+secondNumber;
        if(sum<100)
        {
            return true;
        }
        return false;
    }
    ///<summary>
    ///Create a function that takes an integer and returns the factorial of that integer. 
    ///That is, the integer multiplied by all positive lower integers.
    ///</summary>
    ///<example>
    ///Factorial(3) ➞ 6
    ///Factorial(5) ➞ 120
    ///</example>

    public static int Factorial(int factNum)
    {
        for(int i=factNum-1;i>1;i--)
        {
            factNum = factNum * i;
        }
        return factNum;
    }
}
