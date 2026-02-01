using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Microsoft.AspNetCore.Identity;

namespace Business.Services
{
    public class AccountService(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager
    ) : IAccountService
    {
        public async Task<IdentityResult> RegisterAsync(RegisterDto model)
        {
            var user = new IdentityUser { Email = model.Email, UserName = model.UserName };
            return await userManager.CreateAsync(user, model.Password);
        }

        public async Task<SignInResult> LoginAsync(LoginDto model)
        {
            return await signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: model.RememberMe, lockoutOnFailure: false);
        }

        public async Task LogoutAsync()
        {
            await signInManager.SignOutAsync();
        }

        //public async Task<IdentityUser?> GetUserByEmailAsync(string email)
        //{
        //    return await userManager.FindByEmailAsync(email);
        //}

        //public async Task<IdentityResult> ChangePasswordAsync(string email, string currentPassword, string newPassword)
        //{
        //    var user = await userManager.FindByEmailAsync(email)
        //        ?? throw new InvalidOperationException($"User with email '{email}' not found.");

        //    return await userManager.ChangePasswordAsync(user, currentPassword, newPassword);
        //}

        //public async Task<string> GeneratePasswordResetTokenAsync(string email)
        //{
        //    var user = await userManager.FindByEmailAsync(email)
        //        ?? throw new InvalidOperationException($"User with email '{email}' not found.");

        //    return await userManager.GeneratePasswordResetTokenAsync(user);
        //}

        //public async Task<IdentityResult> ResetPasswordAsync(string email, string token, string newPassword)
        //{
        //    var user = await userManager.FindByEmailAsync(email)
        //        ?? throw new InvalidOperationException($"User with email '{email}' not found.");

        //    return await userManager.ResetPasswordAsync(user, token, newPassword);
        //}

        //public async Task<IdentityResult> DeleteAccountAsync(string email)
        //{
        //    var user = await userManager.FindByEmailAsync(email)
        //        ?? throw new InvalidOperationException($"User with email '{email}' not found.");

        //    return await userManager.DeleteAsync(user);
        //}
    }
}
