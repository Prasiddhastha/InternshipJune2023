using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentWebs.Models
{
    public class StudentDto
    {
        [Key]
        public int StudentId { get; set; }
     
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "DOB")]
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [ForeignKey("Faculty")]
        [Display(Name = "Faculty")]
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
    }
}
