using Utilities.Bases;

namespace Core.Concretes.Entities
{
    public class MealType : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
