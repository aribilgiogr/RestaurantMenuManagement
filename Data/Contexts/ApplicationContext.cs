using Core.Concretes.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : IdentityDbContext<IdentityUser, IdentityRole, string>(options)
    {
        public virtual DbSet<Cuisine> Cuisines { get; set; }
        public virtual DbSet<MealType> MealTypes { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Diet> Diets { get; set; }
    }
}
