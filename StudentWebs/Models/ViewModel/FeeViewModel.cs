using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentWebs.Models.ViewModel
{
    public class FeeViewModel
    {
        public int Id { get; set; }
        public string Semester { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        [NotMapped]
        [Display(Name = "Payment Status")]
        public string PaymentStatus => IsPaid ? "Paid" : "Due";
    }
}
