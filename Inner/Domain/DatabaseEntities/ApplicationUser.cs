using Microsoft.AspNetCore.Identity;

namespace Domain.DatabaseEntities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<BudgetItem> BudgetItems { get; set; } = null!;

        public ICollection<Category> Categories { get; set; } = null!;
    }
}
