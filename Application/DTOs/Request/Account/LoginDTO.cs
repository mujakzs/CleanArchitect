using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Request.Account
{
    public class LoginDTO
    {
        [EmailAddress, Required]
        [RegularExpression(@"^[\w\.\-]+@([\w\-]+\.)+[\w\-]{2,4}$",
            ErrorMessage = "Your Email is not valid, provide a valid email such as @gmail, @hotmail, @yahoo etc.")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*]).{8,}$",
            ErrorMessage = "Your password must be a mix of Alphanumeric and special characters")]
        public string Password { get; set; } = string.Empty;
    }
}
