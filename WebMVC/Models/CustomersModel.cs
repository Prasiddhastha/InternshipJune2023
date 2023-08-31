using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class CustomersModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display (Name="First Name")]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;
        
        public string Email { get; set; }
        [Required]
        [Display(Name = "Phone No:")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; } = string.Empty;
        [Display(Name = "DOB")]
        public DateTime DateOfBirths { get; set; }

    }
}
