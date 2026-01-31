using Business.Services;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Data;
using Data.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class IOC
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("dev")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationContext>()
                    .AddDefaultTokenProviders();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IAccountService, AccountService>();

            return services;
        }
    }
}
