using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string DisplayName { get; set; }

         [Required]
         [EmailAddress]
        public string Email { get; set; }
          
        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$", ErrorMessage = "Password must be complex")]
        public string Password { get; set; }

        [Required]

        public string Username { get; set; }
    }
}