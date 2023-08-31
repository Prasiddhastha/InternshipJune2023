namespace ConsoleApp;

public class DayTwo
{
    public void GetPersons()
    {
        var people = GetPeople();


        foreach (var person in people)
        {
            Console.WriteLine($"{person.Id}. " +
                $"{person.FirstName} {person.LastName} " +
                $"- {person.Age}");
        }

        Console.WriteLine("\nFetch people via Constructor\n");

        foreach (var person in GetPeopleUsingCtor())
        {
            Console.WriteLine(person.ToString());
        }


    }

    private List<Person> GetPeople()
    {
        return new List<Person>
        {
            new Person
            {
                Id = 1,
                FirstName = "Dot",
                LastName = "Net",
                Age = 20
            },
            new Person
            {
                Id = 2,
                FirstName = "C",
                LastName = "#",
                Age = 15
            }
        };
    }

    private List<Person> GetPeopleUsingCtor()
    {
        return new List<Person>
        {
            new Person(1, "Dot","Net", 40),
            new Person(2, "C","#", 30),
            new Person(3, "F","#", 10),
            new Person(4, "Visual","Basic", 50)
        };
    }


    /*
     Create a new class Student (child of Person) that will have
        - Field Of Study (Engg., IT, CSIT....)
        - Semester
        - College
     */
    public void GetStudents()
    {
        Console.WriteLine("\nFetch people via Constructor\n");
        foreach (var student in GetStudentUsingCtor())
        {
            Console.WriteLine(student.ToString());
        }

    }

    private List<Student> GetStudentUsingCtor()
    {
        return new List<Student>
        {
            new Student(1, "Dot","Net", 40,"BCA",2,"Samriddhi"),
            new Student(2, "C","#", 30,"Bsc.CSIT",2,"Cosmos"),
            new Student(3, "F","#", 10,"BBA",2,"KIST"),
            new Student(4, "Visual","Basic", 50,"BBS",2,"Prime")
        };
    }

    //Day2 Excercise
    /// <summary>
    /// In a board game, a piece may advance 1-6 tiles forward depending on the number rolled on a six-sided dice. 
    /// If you advance your piece onto the same tile as another player's piece, both of you earn a bonus.
    ///Can you reach your friend's tile number in the next roll? Create a function that takes your position a
    ///and your friend's position b and returns a boolean representation of whether it's possible to earn a bonus on any die roll. 
    /// </summary>
    /// <example>
    /// possibleBonus(3, 7) ➞ true
    /// possibleBonus(1, 9) ➞ false
    /// possibleBonus(5, 3) ➞ false
    /// </example>
    public static bool PossibleBonus(int a,int b)
    {
        if (a + 1 == b || a + 2 == b|| a + 3 == b|| a + 4 == b|| a + 5 == b || a + 6 ==b)
        {
            return true;
        }
        else return false;
    }

    /// <summary>
    ///Create a function that takes two numbers as arguments(num, length) and returns an array of multiples of num until the array length reaches length.
    /// </summary>
    /// <example>
    /// ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
    /// ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
    /// ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
    /// </example>

    public static void ArrayOfMultiples(int num,int length)
    {
        var mulArray =new int[length];
        for (int i = 1; i <= length; i++)
        {   

                mulArray[i-1] = num * i;
           
        }
        Console.WriteLine($"Multiples of {num} of length{length} is:\n");
        foreach (int i in mulArray)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");
    }
    /// <summary>
    ///Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
    /// </summary>
    /// <example>
    /// ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
    /// ReverseCase("MANY THANKS") ➞ "many thanks"
    /// ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
    /// </example>

    public static void ReverseCase(string txtStr)
    {
       var characters = txtStr.ToCharArray();
        var i = 0;
        foreach (char c in characters)
        {
           if (i==characters.Length)
            {
                break;
            }
            else if(char.IsUpper(c))
            {
                characters[i]=char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                characters[i] = char.ToUpper(c);
            }
            i++;
        }
        Console.WriteLine($"{new string(characters)}");
    }

    /// <summary>
    ///In this challenge, you must verify the equality of two different values given the parameters a and b.
    ///Both the value and type of the parameters need to be equal.The possible types of the given parameters are:
    ///Numbers Strings Booleans (false or true)
    ///What have you learned so far that will permit you to do two different checks(value and type) with a single statement?
    ///Implement a function that returns true if the parameters are equal, and false if they are not.
    /// </summary>
    /// <example>
    /// CheckEquality(1, true) ➞ false
    /// CheckEquality(0, "0") ➞ false
    /// CheckEquality(1,  1) ➞ true
    /// </example>

    public static void CheckEquality(dynamic a1 , dynamic b1)
    {
        if(a1 is int &&  b1 is int && a1==b1|| a1 is string && b1 is string && a1 == b1 || a1 is bool && b1 is bool && a1 == b1)
        {
            Console.WriteLine($"Both are of same type and value => {true}");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    /// <summary>
    ///Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.
    /// </summary>
    /// <example>
    ///IndexOfCapitals("eDaBiT") ➞ [1, 3, 5]
    /// IndexOfCapitals("determine") ➞ []
    /// IndexOfCapitals("STRIKE") ➞ [0, 1, 2, 3, 4, 5]
    /// </example>
    
    public static void IndexOfCap(string txtStr)
    {
        var characters = txtStr.ToCharArray();
        var charIndex = new List<int>();
            var i = 0;
        foreach (char c in characters)
        {
            if (i == characters.Length)
            {
                break;
            }
            else if (char.IsUpper(c))
            {
                charIndex.Add(i);
            }
           
            i++;
        }
        foreach (int c in charIndex)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine("\n");
    }
    public static void Alert(string message)
    {
        var lowCase=message.ToLower();
        if (lowCase.Contains("bomb"))
        {
            Console.WriteLine("Duck!!!");
        }
        else
        {
            Console.WriteLine("There is no bomb, relax.");
        }
    }

    /// <summary>
    ///Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each. 
    /// </summary>
    /// <example>
    ///FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]) ➞ [7, 90, 2]
    ///FindLargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]) ➞ [-34, -2, 7]
    /// FindLargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]) ➞ [0.7634, 9.32, 9]
    /// </example>

    public static void FindLargest(int[][] array1)
    {
        var largeNumber=new int[array1.Length];
        for(int i = 0; i < array1.Length; i++)
        {
            largeNumber[i] = array1[i].Max();
        }
        Console.WriteLine("Large numbers are:");
        foreach (int array2 in largeNumber)
        {
            Console.Write($"{array2} ");
        }
        Console.WriteLine("");
    }

    /// <summary>
    ///ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. 
    ///Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
    /// </summary>
    /// <example>
    ///ValidatePIN("1234") ➞ true
    ///ValidatePIN("12345") ➞ false
    /// ValidatePIN("a234") ➞ false
    /// </example>
    
    public static void ValidatePin(string pin)
    {
        if(!string.IsNullOrEmpty(pin))
        {
            if(pin.Length is 4 or 6) 
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        else
        {
            Console.WriteLine("False");
        }
    }


    /// <summary>
    ///Create a function that takes a string and returns the number (count) of vowels contained within it. 
    /// </summary>
    /// <example>
    ///CountVowels("Celebration") ➞ 5
    ///CountVowels("Palm") ➞ 1
    ///CountVowels("Prediction") ➞ 4e
    /// </example>

    public static void CountVowels(string sentence)
    {
        
        var vowel = "aeiouAEIOU";
        var count =sentence.Count(vowel.Contains);
        
        Console.WriteLine($"Count of vowels in the {sentence} is {count}");
    }


}
