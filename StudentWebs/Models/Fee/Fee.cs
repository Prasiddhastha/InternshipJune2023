using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentWebs.Models.Fee
{
    public class Fee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Semester")]
        public string Semester { get; set; }

        [Display(Name = "Fee Amount")]
        public decimal Amount { get; set; }

        [Display(Name = "Is Paid")]
        public bool IsPaid { get; set; }

        [NotMapped]
        [Display(Name = "Payment Status")]
        public string PaymentStatus => IsPaid ? "Paid" : "Due";

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
