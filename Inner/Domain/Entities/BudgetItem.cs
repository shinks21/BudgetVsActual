using Domain.ValueObjects;

namespace Domain.Entities
{
    public class BudgetItem
    {
        public IdGuid Id { get; }
        public bool Active { get; }
        public DateTime DateCreated { get; }
    }
}
