using System.ComponentModel.DataAnnotations;

namespace StudentWebs.Models.ViewModel
{
    public class Login
    {
        [Key]
        public int? Id { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
