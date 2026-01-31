using Utilities.Bases;

namespace Core.Concretes.Entities
{
    public class MenuItem : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int CuisineId { get; set; }
        public virtual Cuisine? Cuisine { get; set; }
        public int MealTypeId { get; set; }
        public virtual MealType? MealType { get; set; }
    }
}
