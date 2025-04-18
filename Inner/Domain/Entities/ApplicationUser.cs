using Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public bool Active { get; set; }
        public DateCreated DateCreated { get; set; }

        public ICollection<BudgetItem> BudgetItems { get; set; } = null!;
    }
}
