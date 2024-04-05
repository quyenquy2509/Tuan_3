using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _2180604129_TranQuyenQuy.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string? Age { get; set; }
    }
}
