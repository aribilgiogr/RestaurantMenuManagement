using Microsoft.AspNetCore.Identity;
using Utilities.Bases;

namespace Core.Concretes.Entities
{
    public class Menu : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; } = [];
        public string OwnerId { get; set; } = null!;
        public virtual IdentityUser? Owner { get; set; }
        public string QRCodeImageUrl { get; set; } = null!;
    }
}
