using Utilities.Bases;

namespace Core.Concretes.Entities
{
    public class Cuisine : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? CoverImage { get; set; }
        public string? Description { get; set; }
    }
}
