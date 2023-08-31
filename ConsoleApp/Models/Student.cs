namespace ConsoleApp.Models
{
    public class Student:Person
    {
        public string FieldOfStudy { get; set; }
        public int Semester { get; set; }
        public string College { get; set; }
       
        public Student(int id,
                      string firstName,
                      string lastName,
                      int age,string fieldOfStudy,int semester,string college)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FieldOfStudy = fieldOfStudy;
            Semester = semester;
            College = college;
        }

        public override string ToString()
        {
            return $"{Id}. {FirstName} {LastName} - {Age} - {FieldOfStudy} - {Semester} - {College}";
        }
    }
}
