using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; } = string.Empty;

        public override bool Equals(object? obj)
        {
            return obj is AppUser user &&
                   FullName == user.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FullName);
        }
    }
}
