namespace ConsoleApp2;
public class DayFour
{
    public static void GetManufacturer()
    
    {
        var vehicle = GetModel(GetMana());
        foreach (Manufacturer m in GetMana())
        {
            Console.WriteLine($"{m.Id}. {m.name} is manufactured in {m.country}");
        }
        Console.WriteLine("");
        foreach (var vehicles in vehicle)
        {
            Console.WriteLine($"{vehicles.manufacturer.Id}. {vehicles.manufacturer.name} (\"{vehicles.model}\") is manufactured in {vehicles.manufacturer.country}");
        }
        Console.ReadKey();
        Console.Clear();
    }
    private static List<Manufacturer> GetMana() =>
        new List<Manufacturer>()
            {
                new Manufacturer(1,"BMW",Country.Germany),
                new Manufacturer(2,"Lamborghini",Country.Italy),
                new Manufacturer(3,"Vespa",Country.Italy),
                new Manufacturer(4,"Bugatti",Country.France),
                new Manufacturer(5,"BYD",Country.China),
                new Manufacturer(6,"Ford",Country.UnitedKingdom),
                new Manufacturer(7,"Cadillac",Country.UnitedKingdom),
                new Manufacturer(8,"McLaren",Country.UnitedKingdom)
            };
    private static List<Vehicle> GetModel(List<Manufacturer> manufacturer) =>
     new List<Vehicle>()
    {
            new Vehicle(manufacturer[0], "3 Series"),
            new Vehicle(manufacturer[1], "Aventador"),
            new Vehicle(manufacturer[2], "Primavera"),
            new Vehicle(manufacturer[3], "Chiron"),
            new Vehicle(manufacturer[4], "Tang"),
            new Vehicle(manufacturer[5], "Focus"),
            new Vehicle(manufacturer[6], "Escalade"),
            new Vehicle(manufacturer[7], "720S")
    };
    //DayFour Excercise
    /// <summary>
    /// Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
    /// To illustrate:
    ///"123"
    ///We reverse "123" to get "321" and then add "123" to the end, resulting in "321123".
    /// </summary>
    /// <example>
    /// ReverseAndNot(123) ➞ "321123"
    /// ReverseAndNot(152) ➞ "251152"
    /// ReverseAndNot(123456789) ➞ "987654321123456789"
    /// </example>

    public static void ReverseAndNot(int i)
    {
       var save = i.ToString().ToCharArray();
        Array.Reverse(save);
        var reversedString = new string(save);
        Console.WriteLine($"Integer backwards followed by the original integer {i} => {reversedString}{i}");
    }
    /// <summary>
    /// Someone has attempted to censor my strings by replacing every vowel with a *, l*k* th*s. Luckily, 
    /// I've been able to find the vowels that were removed.
    ///Given a censored string and a string of the censored vowels, return the original uncensored string.
    /// </summary>
    /// <example>
    /// uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo") ➞ "Where did my vowels go?"
    /// uncensor("abcd", "") ➞ "abcd"
    /// uncensor("*PP*RC*S*", "UEAE") ➞ "UPPERCASE"
    /// </example>

    public static void Unsensor(string censor, string astrik)
    {
      var censorArray = censor.ToCharArray();
        var astrikArray = astrik.ToCharArray(); 
        var i = 0;
        var j = 0;
        foreach (char c in censorArray)
        {
            if (i == censorArray.Length)
            {
                break;
            }
            else if (c is '*')
            {
                censorArray[i] = astrikArray[j];
                j++;
            }
            else 
            {
                censorArray[i] = censorArray[i];
            }
            i++;
        }
        Console.WriteLine($"Censored string =>{censor}, Uncencored=>{new string(censorArray)}");
    }
    /// <summary>
    ///   Create a function to check if a candidate is qualified in an imaginary coding interview of an imaginary tech startup.
    /// The criteria for a candidate to be qualified in the coding interview is:
    ///The candidate should have complete all the questions.
    ///The maximum time given to complete the interview is 120 minutes.
    ///The maximum time given for very easy questions is 5 minutes each.
    ///The maximum time given for easy questions is 10 minutes each.
    ///The maximum time given for medium questions is 15 minutes each.
    ///The maximum time given for hard questions is 20 minutes each.
    ///If all the above conditions are satisfied, return "qualified", else return "disqualified".
    ///You will be given an array of time taken by a candidate to solve a particular question and the total time taken by the candidate to complete the interview.
    ///Given an array, in a true condition will always be in the format [very easy, very easy, easy, easy, medium, medium, hard, hard].
    ///The maximum time to complete the interview includes a buffer time of 20 minutes.
    /// </summary>
    /// <example>
    /// nterview(new int [] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120) ➞ "qualified"
    /// Interview(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64) ➞  "qualified"
    ///Interview(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120) ➞ "disqualified"
    /// Exceeded the time limit for a medium question.
    ///Interview(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120) ➞ "disqualified"
    /// Did not complete all the questions.
    /// </example>

    public static void Interview(int[] arrays,int totalTime)
    {
        var i = 0;

        if (arrays[0]<=5 && arrays[1]<=5 && arrays[2] <= 10 && arrays[3] <= 10 && arrays[4] <= 15 && arrays[5] <= 15 && arrays[6] <= 20 && arrays[7] <= 20 && totalTime <=120 )
        {
            Console.WriteLine( "qualified"); 
        }
        else 
        {
            Console.WriteLine("disqualified");
        }
    }
    /// <summary>
    ///Carlos is a huge fan of something he calls smooth sentences.
    ///A smooth sentence is one where the last letter of each word is identical to the first letter the following word(and not case sensitive, so "A" would be the same as "a").
    ///The following would be a smooth sentence "Carlos swam masterfully" because "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".
    ///Create a function that determines whether the input sentence is a smooth sentence, returning a boolean value true if it is, false if it is not
    /// </summary>
    /// <example>
    /// IsSmooth("Marta appreciated deep perpendicular right trapezoids") ➞ true
    /// IsSmooth("Someone is outside the doorway") ➞ false
    ///IsSmooth("She eats super righteously") ➞ true
    /// </example>
    public static void IsSmooth(string txt)
    {
        var lowCase = txt.ToLower();
        var splitText = lowCase.Split(' ');
        var endLetter='\0';
        char firstLetter;
        var flag = 0;
        foreach (string s in splitText)
        {
            firstLetter = s[0];
            if (endLetter != '\0' && endLetter != firstLetter)
            {
                flag = 1;
                break;
            }
            endLetter = s[s.Length - 1];
        }
        if(flag==1)
        Console.WriteLine($"{txt} is smooth => false");
        else
        {
            Console.WriteLine($"{txt} is smooth => true");
        }
    }

    /// <summary>
    ///Create a function that determines whether a string is a valid hex code.
    ///A hex code must begin with a pound key # and is exactly 6 characters in length. 
    ///Each character must be a digit from 0-9 or an alphabetic character from A-F. All alphabetic characters may be uppercase or lowercase.
    /// </summary>
    /// <example>
    ///IsValidHexCode("#CD5C5C") ➞ true
    ///IsValidHexCode("#CD5C5C") ➞ true
    ///IsValidHexCode("#CD5C58C") ➞ false
    /// </example>
    
    public static void IsHex(string code)
    {
        var flag = 0;
        var numcode = "ABCDEFabcdef";
        if (code.Length != 7 || code[0] != '#')
        {
            flag = 0;
        }
        else
        {
            for (int i = 1; i < 7; i++)
            {
                if (numcode.Contains(code[i]) || Char.IsDigit(code[i]))
                {
                    flag = 1;
                }
                else
                {
                    break;
                }
            }
        }
        if (flag is 1)
        { Console.WriteLine($"{code} is  Hexcode"); }
        else
        {
            Console.WriteLine($"{code} is not Hexcode ");
        }
    }
    /// <summary>
    ///Create a function that determines whether elements in an array can be re-arranged to form a
    ///consecutive list of numbers where each number appears exactly once.
    /// </summary>
    /// <example>
    ///Cons([5, 1, 4, 3, 2]) ➞ true
    ///Cons([5, 1, 4, 3, 2, 8]) ➞ false
    ///Cons([5, 6, 7, 8, 9, 9]) ➞ false
    /// </example>
    /// 

    public static void Conse(int[] number)
    {
        var arr =number.ToArray();
        Array.Sort(arr);
        var flag = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i-1] + 1 == arr[i] && arr[i - 1] != arr[i])
            {
                flag ++;
            }
            else 
            {
                break; 
            }
        }
        if (flag == arr.Length-1)
        {
            Console.WriteLine("true for:");
            foreach(int i in number)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("false for");
            foreach (int i in number)
            {
                Console.Write(i);
            }
        }
    }
    /// <summary>
    /// A strong Scottish accent makes every vowel similar to an "e", so you should replace every vowel with an "e". Additionally, it is being screamed, so it should be in block capitals.
    ///Create a function that takes a string and returns a string.
    /// </summary>
    /// <example>
    /// ToScottishScreaming("hello world") ➞ "HELLE WERLD"
    /// ToScottishScreaming("Mr. Fox was very naughty") ➞ "MR. FEX WES VERY NEEGHTY"
    /// </example>

    public static void ToScottish(string text)
    {
        Console.WriteLine("");
        var vowel = "aeiouAEIOU";
        var txtArray = text.ToCharArray();
        int i = 0;
        foreach (char c in txtArray)
        {
            if (vowel.Contains(c))
            {
                txtArray[i]='E';
            }
            else
            {
                txtArray[i] = txtArray[i];
            }
            i++;
        }
        Console.WriteLine($"Given text =>{text}, Changed=>{new string(txtArray).ToUpper()}");
    }

    /// <summary>
    /// A robot has been given a list of movement instructions. Each instruction is either left, right, up or down, followed by a distance to move. The robot starts at [0, 0]. You want to calculate where the robot will end up and return its final position as an array.
    /// </summary>
    /// <example>
    /// TrackRobot(new string[] { "right 10", "up 50", "left 30", "down 10" }) ➞ int[] { -20, 40 }
    /// TrackRobot(new string[] { "right 100", "right 100", "up 500", "up 10000" }) ➞ new int[] { 200, 10500 }
    /// </example>
    public static int[] TrackRobot(string[] data)
    {
        var end_posi = new[] { 0, 0 };

        foreach (var datas in data)
        {
            var feed = datas.Split(" ");
            var direction = feed[0];
           var distance = Convert.ToInt32(feed[1]);

            switch (direction)
            {
                case "right":
                    end_posi[0] += distance;
                    break;
                case "left":
                    end_posi[0] -= distance;
                    break;
                case "up":
                    end_posi[1] += distance;
                    break;
                case "down":
                    end_posi[1] -= distance;
                    break;
            }
        }
        return  end_posi;

    }
    /// <summary>
    /// Every quadratic curve y = a x² + b x + c has a vertex point: the turning point where the curve stops heading down and starts going up.
    /// Given the values a, b and c, you need to return the coordinates of the vertex. Return your answers rounded to 2 decimal places.
    /// </summary>
    /// <example>
    /// FindVertex(1, 0, 25)  ➞ [0, 25]
    /// The vertex of y=x²+25 is at (0, 25).
    /// FindVertex(1, 10, 4) ➞ [-5, -21]
    /// The vertex of y=x²+10x+4 is at (-5, -21).
    /// </example>
    public static (double,double) FindVertex(double a, double b, double c)
    {
        double x_point = (-b / (2 * a));
        double y_point = (a + Math.Pow(x_point,2) + (b * x_point) + c);
        double xround = Math.Round(x_point, 2);
        double yround = Math.Round(y_point, 2);
        return (xround, yround);
    }
    /// <summary>
    /// Given a string, reverse all the words which have odd length. The even length words are not changed.
    /// </summary>
    /// <example>
    /// ReverseOdd("Bananas") ➞ "sananaB"
    /// ReverseOdd("One two three four") ➞ "enO owt eerht four"
    /// ReverseOdd("Make sure uoy only esrever sdrow of ddo length")
    /// </example>

    public static void ReverseOdd(string sentence)
    {
        var sen = sentence.Split(" ");
        var i = 0;
        foreach ( var sens in sen)
        {
            if(i == sen.Length - 1)
            {
                break;
            }
            else if (sen[i].Length % 2 != 0) 
            {
                var charArray = sen[i].ToCharArray();
                Array.Reverse(charArray);
                sen[i] = new string(charArray);
            }
            i++;
        }
        Console.WriteLine($"{sentence} to =>{string.Join(" ", sen)}");

    }
}
