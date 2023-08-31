using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentWebs.Models.ViewModel
{
    public class FeeCreateViewModel
    {
        public int StudentId { get; set; }

        [Required]
        public string Semester { get; set; }

        [Required]
        public decimal Amount { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Display(Name = "Symbol No")]
        public string? SymbolNo { get; set; }
        // Property to store the image path
        public string? ImagePath { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile? Image { get; set; }
    }
}
