using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concretes.DTOs
{
    public record RegisterDto
    {
        [Required, Display(Name = "Username", Prompt = "Username")]
        public required string UserName { get; init; }


        [Required, EmailAddress, Display(Name = "Email Address", Prompt = "Email Address")]
        public required string Email { get; init; }


        [Required, DataType(DataType.Password), Display(Name = "Password", Prompt = "Password")]
        public required string Password { get; init; }


        [Required, DataType(DataType.Password), Compare(nameof(Password)), Display(Name = "Confirm Password", Prompt = "Confirm Password")]
        public required string ConfirmPassword { get; init; }
    }

    public record LoginDto
    {
        [Required, Display(Name = "Username", Prompt = "Username")]
        public required string UserName { get; init; }


        [Required, DataType(DataType.Password), Display(Name = "Password", Prompt = "Password")]
        public required string Password { get; init; }

        [Display(Name = "Remember Me", Prompt = "Remember Me")]
        public bool RememberMe { get; init; }
    }
}
