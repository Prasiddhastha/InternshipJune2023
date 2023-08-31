namespace ConsoleApp.Models;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person()
    {
        
    }

    public Person(int id,
                  string firstName,
                  string lastName,
                  int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName} - {Age}";
    }
}
