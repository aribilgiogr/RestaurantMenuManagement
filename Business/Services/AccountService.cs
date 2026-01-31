using Core.Abstracts.IServices;
using Microsoft.AspNetCore.Identity;

namespace Business.Services
{
    public class AccountService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) : IAccountService
    {
    }
}
