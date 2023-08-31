

namespace DesktopApplication.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SubjectName { get; set; } = string.Empty;

    }

  


}
