using System.ComponentModel.DataAnnotations;

namespace StudentWebs.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Faculty Name")]
        public string FacultyName { get; set; }
        public ICollection<Teacher>? Teachers { get; set; }
    }
}
