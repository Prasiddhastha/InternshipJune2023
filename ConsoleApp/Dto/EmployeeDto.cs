

namespace ConsoleApp.Dto
{
    public class EmployeeInputDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }=string.Empty;

        public int Age { get; set; }
        public int Salary { get; set; }
    }
    public class EmployeeDto:EmployeeInputDto
    {
        public int Id { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } =string.Empty;
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
