//Person person = new(1,"Gita", "Dhakal","Dhumbarahi",20);
//Console.WriteLine($"Id:{person.Id}");
//Console.WriteLine($"Firstname:{person.FirstName}");
//Console.WriteLine($"Lastname:{person.LastName}");
//Console.WriteLine($"Address:{person.Address}");
//Console.WriteLine($"Age:{person.Age}");

//Person updatedSome = person with { Id = 2, FirstName = "Ram", Address = "Swoyambhu" };

//Console.WriteLine(updatedSome);




DayFour.GetManufacturer();


DayFour.ReverseAndNot(567);
DayFour.Unsensor("H*ll* th*s *s m* R*m.", "eoiiea");

//[very easy, very easy, easy, easy, medium, medium, hard, hard]
var array1 = new int[] { 2, 5, 10, 10, 15, 15, 20, 20};
var array2 = new int[] { 5, 10, 10, 15, 20, 20 };
var totalTime = 120;
Console.WriteLine($"for the given totaltime=>{totalTime} and ({string.Join(", ", array1)}) ");
DayFour.Interview(array1, totalTime);
Console.WriteLine($"for the given totaltime=>{totalTime} and ({string.Join(", ", array2)}) ");
DayFour.Interview(array2, totalTime);

DayFour.IsSmooth("She eats super righteously.");
DayFour.IsSmooth("Hari is a doctor.");

DayFour.IsHex("&CD5CDa");
DayFour.IsHex("#C25CEd");

var array3 = new int[] { 5, 3, 6, 4, 7 };
var array4 = new int[] { 5, 3, 6, 4, 9, 9 };
DayFour.Conse(array3);
DayFour.Conse(array4);

DayFour.ToScottish("Hello World");

var data = new [] { "right 30", "left 20", "up 10", "down 50" };
Console.WriteLine($"for the given instruction ({string.Join(", ", data)}) ");
var endposi = DayFour.TrackRobot(data);
Console.WriteLine($"The final position of the robot will be({endposi[0]}xunit,{endposi[1]}yunit)");

Console.WriteLine("Finding the vertex of quadratic");
double a = 1;
double b = 2;
double c = 5;
Console.WriteLine($"For the given points ({a},{b},{c}) the vertex is at {DayFour.FindVertex(a, b, c)}");

DayFour.ReverseOdd("Hello Ram.");
