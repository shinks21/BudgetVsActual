using Domain.ValueObjects;

namespace Domain.DatabaseEntities
{
    public class Category
    {
        public IdGuid Id { get; set; } = null!;

        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }

        public string CategoryName { get; set; } = string.Empty;

        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;

    }
}
