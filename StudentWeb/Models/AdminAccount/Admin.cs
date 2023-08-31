using DesktopApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentWeb.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
       
        public string Password { get; set; }
        public Teacher Teacher { get; set; }
    }
}
