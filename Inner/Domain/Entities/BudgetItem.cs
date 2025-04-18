using Domain.ValueObjects;

namespace Domain.Entities
{
    public class BudgetItem
    {
        public IdGuid Id { get; set; }

        public bool Active { get; set; }
        public DateCreated DateCreated { get; set; }

        public ApplicationUser CreatedBy { get; set; }
        public Currency Amount { get; set; }
        public ItemDate Date { get; set; }

    }
}
