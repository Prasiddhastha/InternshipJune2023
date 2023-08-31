
namespace DesktopApplication.Models
{
    public class Teacher 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TeacherName { get; set; }
        public string Address { get; set; }

        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
