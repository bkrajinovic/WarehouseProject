using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Warehouse.Models
{
    public class AuthUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

    }
}