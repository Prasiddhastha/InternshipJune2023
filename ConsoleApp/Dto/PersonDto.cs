namespace ConsoleApp.Dto;

public class PersonInputDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

public class PersonDto : PersonInputDto
{
    public int Id { get; set; }
}