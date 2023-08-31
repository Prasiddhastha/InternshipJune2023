



namespace DesktopApplication.Models
{
    public class Student 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }   
        
        public string Address { get; set; }
        public string ImageUrl { get; set; }
       
        [EmailAddress]
        public string Email { get; set; }

        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}
