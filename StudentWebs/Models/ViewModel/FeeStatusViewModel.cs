using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentWebs.Models.ViewModel
{
    public class FeeStatusViewModel
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Is Paid")]
        public bool IsPaid { get; set; }
        //public string FullName => $"{FirstName} {LastName}";
        public string ImagePath { get; set; }

        [Display(Name = "Symbol No")]
        public string SymbolNo { get; set; }
        public decimal Amount { get; set; }

        public List<FeeViewModel> Fees { get; set; }
    }

}
