using System.ComponentModel.DataAnnotations;

namespace StudentWeb.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FacultyName { get; set; }
    }
}
