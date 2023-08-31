
using StudentWebs.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentWebs.Models
{
    public class Teacher 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "HOD Name")]
        public string TeacherName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }

       

        [Display(Name = "Contact No")]
        [StringLength(10, MinimumLength = 7, ErrorMessage = "Contact No must be 7 or 10 digits long.")]
        public string ContactNo { get; set; }
        public string? ImagePath { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile? Image { get; set; }

        [ForeignKey("Faculty")]
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
    }
}
