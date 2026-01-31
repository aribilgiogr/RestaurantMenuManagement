using Utilities.Bases;

namespace Core.Concretes.Entities
{
    public class Diet : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
