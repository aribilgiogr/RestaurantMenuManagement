using Core.Concretes.DTOs;
using Microsoft.AspNetCore.Identity;

namespace Core.Abstracts.IServices
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterAsync(RegisterDto model);
        Task<SignInResult> LoginAsync(LoginDto model);
        Task LogoutAsync();
        //Task<IdentityUser?> GetUserByEmailAsync(string email);
        //Task<IdentityResult> ChangePasswordAsync(string email, string currentPassword, string newPassword);
        //Task<string> GeneratePasswordResetTokenAsync(string email);
        //Task<IdentityResult> ResetPasswordAsync(string email, string token, string newPassword);
        //Task<IdentityResult> DeleteAccountAsync(string email);
    }
}
