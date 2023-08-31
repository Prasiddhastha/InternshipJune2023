using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name ="First Name")]
        [Required(ErrorMessage = "First Name is a required field.")]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Display(Name ="DOB")]
        public DateTime DateOfBirth { get; set; }
    }
}
