using Domain.ValueObjects;

namespace Domain.DatabaseEntities
{
    public class BudgetItem
    {
        public IdGuid Id { get; set; } = null!;

        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }

        public decimal Amount { get; set; }
        public DateOnly Date { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
