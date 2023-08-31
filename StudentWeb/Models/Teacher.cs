
using StudentWeb.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopApplication.Models
{
    public class Teacher 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TeacherName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }

        public string ImageUrl{ get; set; }

        [ForeignKey("Faculty")]
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
