
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentWebs.Models.Fee;

namespace StudentWebs.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
     
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Range(202300, 202400, ErrorMessage = "Symbol No must be between 202300 and 202400")]
        [Display(Name = "Symbol No")]
        public string SymbolNo { get; set; }

      
        [Display(Name = "Contact No")]
        [StringLength(10, MinimumLength = 7, ErrorMessage = "Contact No must be 7 or 10 digits long.")]
        public string ContactNo { get; set; }
        public string? ImagePath { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile? Image { get; set; }


        [ForeignKey("Faculty")]
        [Display(Name = "Faculty")]
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        
    }
}
